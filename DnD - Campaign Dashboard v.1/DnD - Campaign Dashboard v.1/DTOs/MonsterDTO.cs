using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.DTOs
{
    public class MonsterDTO
    {
        public string Name { get; set; }
        public int Challenge { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public string Alignment { get; set; }
    }
}