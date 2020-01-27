using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class ScenarioSpecialAssignment
    {
        public int ScenarioSpecialAssignmentId { get; set; }


        public int ScenarioId { get; set; }
        public Scenario Scenario { get; set; }

        public int SpecialId { get; set; }
        public Special Special { get; set; }
    }
}
