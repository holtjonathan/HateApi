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
    public class SpecialController : ControllerBase
    {
        private readonly IDataRepository<Special> _dataRepository;

        public SpecialController(IDataRepository<Special> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Special> specials = _dataRepository.GetAll();
            return Ok(specials);
        }

        [HttpGet("{id}", Name = "GetSpecial")]
        public IActionResult Get(long id)
        {
            var special = _dataRepository.Get(id);

            if (special == null)
            {
                return NotFound("The Special record couldn't be found.");
            }

            return Ok(special);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Special special)
        {
            if (special == null)
            {
                return BadRequest("Special is null.");
            }

            _dataRepository.Add(special);
            return CreatedAtRoute(
                  "GetSpecial",
                  new { Id = special.SpecialId },
                  special);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Special special)
        {
            if (special == null)
            {
                return BadRequest("Special is null.");
            }

            var specialtoUpdate = _dataRepository.Get(id);
            if (specialtoUpdate == null)
            {
                return NotFound("The Special record couldn't be found.");
            }

            _dataRepository.Update(specialtoUpdate, special);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var special = _dataRepository.Get(id);
            if (special == null)
            {
                return NotFound("The Special record couldn't be found.");
            }

            _dataRepository.Delete(special);
            return NoContent();
        }
    }
}