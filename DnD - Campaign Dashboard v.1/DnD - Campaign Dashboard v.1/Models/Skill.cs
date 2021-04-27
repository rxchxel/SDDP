using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Skill : ParentClass
    {
        [Required]
        public string AssociatedAttribute { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Value { get; set; }
    }
}