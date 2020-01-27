using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class Reward
    {
        //Can you see this?
        public int RewardId { get; set; }
        public string Description { get; set; }

        public Scenario AttackerScenario { get; set; }
        public Scenario DefenderScenario { get; set; }
    }
}
