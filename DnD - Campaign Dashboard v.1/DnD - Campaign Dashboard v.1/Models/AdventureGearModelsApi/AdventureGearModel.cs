using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.AdventureGearModelsApi
{
    public class AdventureGearModel : ParentClass
    {
        public string name { get; set; }

        [Display(Name = "Equipment Category")]
        public Equipment_Category equipment_category { get; set; }

        [Display(Name = "Gear Category")]
        public Gear_Category gear_category { get; set; }
        public Cost Cost { get; set; }
        public int Weight { get; set; }
    }

    public class Equipment_Category
    {
        public string index { get; set; }
        public string name { get; set; }
    }

    public class Gear_Category
    {
        public string index { get; set; }
        public string name { get; set; }
    }

    public class Cost
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

}