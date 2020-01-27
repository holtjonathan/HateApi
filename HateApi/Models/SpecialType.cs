using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HateApi.Models
{
    public class SpecialType
    {
        public int SpecialTypeId { get; set; }
        public string Name { get; set; }

        //public int SpecialRef { get; set; }
        public Special Special { get; set; }
    }
}
