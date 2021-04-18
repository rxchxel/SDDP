using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.DTOs
{
    public class ArmourDTO 
    {
        public string Name { get; set; }
        public string ArmourClass { get; set; }
        public string ArmourCategory { get; set; }
        public int Strenth { get; set; }
        public int Stealth { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }
    }
}