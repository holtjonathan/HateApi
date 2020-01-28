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
        private readonly IHateManager _hateRepo;

        public ScenarioController(IHateManager dataRepository)
        {//test
            _hateRepo = dataRepository;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            var scenarios = _hateRepo.GetAll();
            //IEnumerable<Scenario> scenarios = _hateRepo.GetAll();
            return Ok(scenarios);
        }
    }
}