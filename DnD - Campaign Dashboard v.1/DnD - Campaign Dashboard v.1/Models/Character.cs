using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Character : ParentClass
    {
        public int Level { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public int TempHP { get; set; }
        public byte ProfBonus { get; set; }
        public byte Inspiration { get; set; }
        public byte Strength { get; set; }
        public byte Dexterity { get; set; }
        public byte Constitution { get; set; }
        public byte Intelligence { get; set; }
        public byte Wisdom { get; set; }
        public byte Charisma { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Armour> Armours { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<MagicItem> MagicItems { get; set; }
        public List<AdventuringGear> AdventuringGears { get; set; }
    }
}