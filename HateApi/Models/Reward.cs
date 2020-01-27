using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class Reward
    {
        public int RewardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ResourceReward { get; set; }
        public int HateReward { get; set; }
        public string UnitUpgrade { get; set; }
        public string RewardType { get; set; }
        public IList<ScenarioRewardAssignment> ScenarioRewardAssignments { get; set; }
    }
}
