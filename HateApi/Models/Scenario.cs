using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class Scenario
    {
        public int ScenarioId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<ScenarioRewardAssignment> ScenarioRewardAssignments { get; set; }
        public IList<ScenarioSpecialAssignment> ScenarioSpecialAssignments { get; set; }
    }
}
