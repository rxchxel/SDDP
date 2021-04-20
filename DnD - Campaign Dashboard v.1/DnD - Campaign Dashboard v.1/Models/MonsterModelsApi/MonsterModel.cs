using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.MonsterModelsApi
{
    public class MonsterModel : ParentClass
    {
        public string name { get; set; }

        public string Size { get; set; }

        public string Type { get; set; }

        public object Subtype { get; set; }

        public string Alignment { get; set; }

        [Display(Name = "Armor Class")]
        public int armor_class { get; set; }

        [Display(Name = "Hit Points")]
        public int hit_points { get; set; }

        [Display(Name = "Hit Dice")]
        public string hit_dice { get; set; }

        public Speed Speed { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }
        public Proficiency[] Proficiencies { get; set; }

        [Display(Name = "Damage Vulnerabilities")]
        public object[] damage_vulnerabilities { get; set; }

        [Display(Name = "Damage Resistances")]
        public object[] damage_resistances { get; set; }

        [Display(Name = "Damage Immunities")]
        public object[] damage_immunities { get; set; }

        [Display(Name = "Condition Immunities")]
        public object[] condition_immunities { get; set; }
        public Senses Senses { get; set; }
        public string Languages { get; set; }

        [Display(Name = "Challenge Rating")]
        public int challenge_rating { get; set; }
        public int Xp { get; set; }

        [Display(Name = "Special Abilities")]
        public Special_Abilities[] special_abilities { get; set; }
        public Action[] Actions { get; set; }

        [Display(Name = "Legendary Actions")]
        public Legendary_Actions[] legendary_actions { get; set; }
    }

    public class Speed
    {
        public string Walk { get; set; }
        public string Swim { get; set; }
    }

    public class Senses
    {
        public string Darkvision { get; set; }

        [Display(Name = "Passive Perception")]
        public int passive_perception { get; set; }
    }

    public class Proficiency
    {
        public int Value { get; set; }

        [Display(Name = "Proficiency")]
        public Proficiency1 proficiency { get; set; }
    }

    public class Proficiency1
    {
        public string Name { get; set; }
    }

    public class Special_Abilities
    {
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string desc { get; set; }

        [Display(Name = "Dc")]
        public Dc dc { get; set; }
    }

    public class Dc
    {
        [Display(Name = "Type")]
        public Dc_Type dc_type { get; set; }

        [Display(Name = "Value")]
        public int dc_value { get; set; }

        [Display(Name = "Success Type")]
        public string success_type { get; set; }
    }

    public class Dc_Type
    {
        public string Name { get; set; }
    }

    public class Action
    {
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string desc { get; set; }


        public Options Options { get; set; }
        public Damage[] Damage { get; set; }

        [Display(Name = "Attack Bonus")]
        public int attack_bonus { get; set; }

        [Display(Name = "Dc1")]
        public Dc1 dc { get; set; }
        public Usage Usage { get; set; }
    }

    public class Options
    {
        public int Choose { get; set; }
        public From[][] from { get; set; }
    }

    public class From
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Type { get; set; }
    }

    public class Dc1
    {
        [Display(Name = "Type")]
        public Dc_Type1 dc_type { get; set; }

        [Display(Name = "Value")]
        public int dc_value { get; set; }

        [Display(Name = "Success Type")]
        public string success_type { get; set; }
    }

    public class Dc_Type1
    {
        public string Name { get; set; }
    }

    public class Usage
    {
        public string Type { get; set; }
        public int Times { get; set; }
    }

    public class Damage
    {
        [Display(Name = "Damage Type")]
        public Damage_Type damage_type { get; set; }

        [Display(Name = "Damage Dice")]
        public string damage_dice { get; set; }
    }

    public class Damage_Type
    {
        public string name { get; set; }
    }

    public class Legendary_Actions
    {
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string desc { get; set; }

        [Display(Name = "Attack Bonus")]
        public int attack_bonus { get; set; }
        public Damage1[] Damage { get; set; }
    }

    public class Damage1
    {
        [Display(Name = "Damage Type")]
        public Damage_Type1 damage_type { get; set; }

        [Display(Name = "Damage Dice")]
        public string damage_dice { get; set; }
    }

    public class Damage_Type1
    {
        public string Name { get; set; }
    }
}