using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models.MagicItemModelsApi
{
    public class MagicItemsModel : ParentClass
    {
        public int count { get; set; }
        public MagicItemResultModel[] results { get; set; }
    }

    

}