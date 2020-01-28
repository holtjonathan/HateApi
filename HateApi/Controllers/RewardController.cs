using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HateApi.Models;
using HateApi.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardController : ControllerBase
    {
        private readonly IDataRepository<Reward> _dataRepository;

        public RewardController(IDataRepository<Reward> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Reward> rewards = _dataRepository.GetAll();
            return Ok(rewards);
        }

        [HttpGet("{id}", Name = "GetReward")]
        public IActionResult Get(long id)
        {
            var reward = _dataRepository.Get(id);

            if (reward == null)
            {
                return NotFound("The Reward record couldn't be found.");
            }

            return Ok(reward);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reward reward)
        {
            if (reward == null)
            {
                return BadRequest("Reward is null.");
            }

            _dataRepository.Add(reward);
            return CreatedAtRoute(
                  "GetReward",
                  new { Id = reward.RewardId },
                  reward);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Reward reward)
        {
            if (reward == null)
            {
                return BadRequest("Reward is null.");
            }

            var rewardtoUpdate = _dataRepository.Get(id);
            if (rewardtoUpdate == null)
            {
                return NotFound("The Reward record couldn't be found.");
            }

            _dataRepository.Update(rewardtoUpdate, reward);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var reward = _dataRepository.Get(id);
            if (reward == null)
            {
                return NotFound("The Reward record couldn't be found.");
            }

            _dataRepository.Delete(reward);
            return NoContent();
        }
    }
}