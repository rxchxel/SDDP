using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Skill : ParentClass
    {
        public string AssociatedAttribute { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}