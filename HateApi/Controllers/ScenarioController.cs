using System.Collections.Generic;
using HateApi.Models;
using HateApi.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HateApi.Controllers
{
    [Route("api/scenario")]
    [ApiController]
    public class ScenarioController : ControllerBase
    {
        private readonly IDataRepository<Scenario> _dataRepository;

        public ScenarioController(IDataRepository<Scenario> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Scenario> scenarios = _dataRepository.GetAll();
            return Ok(scenarios);
        }

        [HttpGet("{id}", Name = "GetScenario")]
        public IActionResult Get(long id)
        {
            var scenario = _dataRepository.Get(id);

            if (scenario == null)
            {
                return NotFound("The Scenario record couldn't be found.");
            }

            return Ok(scenario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Scenario scenario)
        {
            if (scenario == null)
            {
                return BadRequest("Scenario is null.");
            }

            _dataRepository.Add(scenario);
            return CreatedAtRoute(
                  "GetScenario",
                  new { Id = scenario.ScenarioId },
                  scenario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Scenario scenario)
        {
            if (scenario == null)
            {
                return BadRequest("Scenario is null.");
            }

            var scenariotoUpdate = _dataRepository.Get(id);
            if (scenariotoUpdate == null)
            {
                return NotFound("The Scenario record couldn't be found.");
            }

            _dataRepository.Update(scenariotoUpdate, scenario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var scenario = _dataRepository.Get(id);
            if (scenario == null)
            {
                return NotFound("The Scenario record couldn't be found.");
            }

            _dataRepository.Delete(scenario);
            return NoContent();
        }
    }
}