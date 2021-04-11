using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.DTOs
{
    public class SpellDTO : ParentClass
    {
        public int Level { get; set; }
        public int CastingTime { get; set; }
        public bool Ritual { get; set; }
        public string AttackType { get; set; }
        public int Duration { get; set; }
        public int RangeArea { get; set; }
        public int AttackRoll_SavingThrow { get; set; }
        public string DamageType { get; set; }

    }
}