using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class Scenario
    {
        public int ScenarioId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public IList<ScenarioRewardAssignment> ScenarioRewardAssignments { get; set; }
        [JsonIgnore]
        public IList<ScenarioSpecialAssignment> ScenarioSpecialAssignments { get; set; }
    }
}
