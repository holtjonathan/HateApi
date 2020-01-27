using HateApi.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HateApi.Models.DataManager
{
    public class HateManager : IHateManager
    {
        readonly HateContext _hateContext;

        public HateManager(HateContext hateContext)
        {
            _hateContext = hateContext;
        }

        //public IEnumerable<Scenario> GetAll()
        public string GetAll()
        {
            var scens = _hateContext.Scenarios
                .Include(rewardAss => rewardAss.ScenarioRewardAssignments)
                .Include(special => special.ScenarioSpecialAssignments)
               // .ThenInclude(reward => reward.Reward)
                .ToList();
            var options = new JsonSerializerOptions
            {
                ReferenceHandling = ReferenceHandling.Preserve,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(scens, options);
            return json;
           // return _hateContext.Scenarios.ToList();
        }
    }
}
