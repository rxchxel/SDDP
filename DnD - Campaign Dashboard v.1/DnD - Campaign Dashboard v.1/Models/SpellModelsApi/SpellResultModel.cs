using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnD___Campaign_Dashboard_v._1.Models.SpellModelsApi
{
    public class Spells : ParentClass
    {
        public int count { get; set; }

        //[results]
        public IList<SpellModel> results { get; set; }
    }
}
