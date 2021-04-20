using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.MagicItemModelsApi
{
    public class MagicItemModel : ParentClass
    {
        
        public string name { get; set; }

        [Display(Name = "Equipment Category")]
        public Equipment_Category equipment_category { get; set; }

        [Display(Name = "Description")]
        public string[] desc { get; set; }
        
    }

    public class Equipment_Category
    {
        public string index { get; set; }
        public string name { get; set; }
        
    }

}