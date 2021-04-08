using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Encounter : ParentClass
    {
        public string Alignment { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public int Rating { get; set; }
        public int Challenge { get; set; }
    }
}