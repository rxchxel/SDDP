using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Campaign : ParentClass
    {
        [StringLength(1000)]
        public string Story { get; set; }
        [StringLength(1000)]
        public string Note { get; set; }
        public List<Encounter> Encounters { get; set; }
        [Required]
        [MaxLength(4)]
        public int[] Characters { get; set; }
        [Required]
        public string DMUserId { get; set; }
    }
}