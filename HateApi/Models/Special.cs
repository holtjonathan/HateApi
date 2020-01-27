using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class Special
    {
        public int SpecialId { get; set; }
        public string Name { get; set; }

        public int SpecialTypeId { get; set; }
        public SpecialType SpecialType { get; set; }


        public int ScenarioId { get; set; }
        public Scenario Scenario { get; set; }
    }
}
