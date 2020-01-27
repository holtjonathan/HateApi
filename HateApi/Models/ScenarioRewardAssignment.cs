using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class ScenarioRewardAssignment
    {
        public int ScenarioRewardAssignmentId { get; set; }

        public int ScenarioId { get; set; }
        public Scenario Scenario { get; set; }

        public int RewardId { get; set; }
        public Reward Reward { get; set; }
    }
}
