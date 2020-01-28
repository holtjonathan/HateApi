using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using HateApi.GraphQL;
using HateApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HateApi.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private readonly HateContext _db;

        public GraphQLController(HateContext db) => _db = db;

        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema
            {
                Query = new ScenarioQuery(_db)
            };

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;

            });

            return Ok(json);
        }
    }
}

//ui/playground
//{
//  scenario(id: 1)
//{
//    scenarioId
//    description
//    name
//    scenarioRewardAssignments {
//        reward {
//            name
//            description
//          hateReward
//        resourceReward
//        }
//    }
//    scenarioSpecialAssignments {
//        scenarioSpecialAssignmentId
//        special {
//            name
//            description
//        }
//    }
//}
//}


//ui/playground example:
//{
//  scenarios {
//    scenarioId
//    description
//    name
//  }
//  rewards {
//    rewardId
//    name
//    description
//    hateReward
//    resourceReward
//    unitUpgrade
//  }
//  specials {
//    description
//    name
//    specialId
//  }
//  scenario(id: 3)
//{
//    scenarioId
//    description
//    name
//  }
//}
