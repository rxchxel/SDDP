using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    //A parent class at the top of the class hierarchy that allows all other entities to have the comon properties of ID and Name
    public abstract class ParentClass
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}