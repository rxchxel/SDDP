using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class InvitationModel
    {
        public string UserId { get; set; }
        public int Campaign_Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}