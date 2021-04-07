using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Weapons : ItemParentClass
    {
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public string WeaponCategory { get; set; }
        public int WeaponRange { get; set; }
        public string WeaponProperties { get; set; }
    }
}