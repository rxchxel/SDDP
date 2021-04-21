using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.WeaponModelsApi
{
    public class WeaponModel : ParentClass
    {
        public string name { get; set; }

        [Display(Name = "Equipment Category")]
        public Equipment_Category equipment_category { get; set; }

        [Display(Name = "Weapon Category")]
        public string weapon_category { get; set; }

        [Display(Name = "Weapon Range")]
        public string weapon_range { get; set; }

        [Display(Name = "Category Range")]
        public string category_range { get; set; }
        public Cost Cost { get; set; }
        public Damage Damage { get; set; }
        public Range Range { get; set; }
        public int Weight { get; set; }
        public Property1[] Properties { get; set; }

        [Display(Name = "Throw Range")]
        public Throw_Range throw_range { get; set; }
    }

    public class Equipment_Category
    {
        public string index { get; set; }
        public string name { get; set; }
    }

    public class Cost
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Damage
    {
        [Display(Name = "Damage Dice")]
        public string damage_dice { get; set; }

        [Display(Name = "Damage Type")]
        public Damage_Type damage_type { get; set; }
    }

    public class Damage_Type
    {
        public string index { get; set; }
        public string name { get; set; }

    }

    public class Range
    {
        public int Normal { get; set; }

        [JsonProperty("long")]
        [Display(Name = "Long")]
        public object _long { get; set; }
    }

    public class Throw_Range
    {
        public int Normal { get; set; }

        [JsonProperty("long")]
        [Display(Name = "Long")]
        public int _long { get; set; }
    }

    public class Property1
    {
        public string index { get; set; }
        public string name { get; set; }
    }


}