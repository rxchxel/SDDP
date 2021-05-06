using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class CampaignViewModel
    {
        public InvitationModel Invitation { get; set; }
        public List<Character> Characters { get; set; }
        public List<Encounter> Encounters { get; set; }
        public Campaign Campaign { get; set; }
    }
}