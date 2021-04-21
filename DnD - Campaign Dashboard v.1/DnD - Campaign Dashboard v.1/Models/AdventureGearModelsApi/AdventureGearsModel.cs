using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.AdventureGearModelsApi
{
    public class AdventureGearsModel : ParentClass
    {
        public string index { get; set; }
        public string name { get; set; }
        public AdventureGearResultModel[] Equipment { get; set; }
    }
}