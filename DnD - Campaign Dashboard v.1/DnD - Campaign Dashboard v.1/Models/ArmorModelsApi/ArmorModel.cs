using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.ArmorModelsApi
{
    public class ArmorModel : ParentClass
    {
        public string name { get; set; }

        [Display(Name = "Equipment Category")]
        public Equipment_Category equipment_category { get; set; }

        [Display(Name = "Armor Category")]
        public string armor_category { get; set; }

        [Display(Name = "Armor Class")]
        public Armor_Class armor_class { get; set; }

        [Display(Name = "Str Minimum")]
        public int str_minimum { get; set; }

        [Display(Name = "Stealth Disadvantage")]
        public bool stealth_disadvantage { get; set; }
        public int Weight { get; set; }
        public Cost Cost { get; set; }
    }

    public class Equipment_Category
    {
        public string index { get; set; }
        public string name { get; set; }
    }

    public class Armor_Class
    {
        
        public int Base { get; set; }

        [Display(Name = "Dex Bonus")]
        public bool dex_bonus { get; set; }

        [Display(Name = "Max Bonus")]
        public int max_bonus { get; set; }
    }

    public class Cost
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

}