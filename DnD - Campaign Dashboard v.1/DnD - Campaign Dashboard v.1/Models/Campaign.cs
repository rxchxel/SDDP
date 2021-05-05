using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Campaign : ParentClass
    {
        //Data annotation to be used in validation of properties, sets the character length to 1000
        [StringLength(1000)]
        public string Story { get; set; }

        //Data annotation to be used in validation of properties, sets the character length to 1000
        [StringLength(1000)]
        public string Note { get; set; }
        
        //Creates a list of encounters that will serve as the fights, boss battles of the campaign
        public List<Encounter> Encounters { get; set; }
        
        //Represents the dungeon master user ID, so we can check if the person viewing the campaign
        //is the one that created it and then pass the correct view
        [Required]
        public string DMUserId { get; set; }
        
        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }
}