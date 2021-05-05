using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public abstract class ItemParentClass : ParentClass
    {
        //Gives a parent class that contains the two properties inherent to every Item
        public int Cost { get; set; }
        public int weight { get; set; }
    }
}