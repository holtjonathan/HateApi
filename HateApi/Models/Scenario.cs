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
        public string Prereq { get; set; }
        public List<Special> Specials { get; set; }
        public int AttackerRewardId { get; set; }
        public int DefenderRewardId { get; set; }


        public virtual Reward AttackerReward { get; set; }

        public virtual Reward DefenderReward { get; set; }
    }
}
