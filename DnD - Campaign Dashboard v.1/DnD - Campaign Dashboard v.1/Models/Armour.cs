using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Armour : ItemParentClass
    {
        public string ArmourClass { get; set; }
        public string ArmourCategory { get; set; }
        public int Strenth { get; set; }
        public int Stealth { get; set; }
    }
}