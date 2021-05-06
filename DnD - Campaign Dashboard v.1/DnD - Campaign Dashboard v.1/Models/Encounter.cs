using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    //Encounters serve as the events in a campaign, e.g fights with enemies and bosses
    //Will allow dungeon masters to keep track of what events occur during a given campaign
    public class Encounter : ParentClass
    {
        [Required]
        public string Alignment { get; set; }
        [Required]
        public int Size { get; set; }
        [StringLength(10)]
        [Required]
        public string Difficulty { get; set; }
        [Required]
        public int CampaignId { get; set; }
    }
}