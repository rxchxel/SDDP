using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DnD___Campaign_Dashboard_v._1.Models;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class InvitationController : Controller
    {
        private ApplicationUserManager _userManager;

        public InvitationController() { }

        public InvitationController(ApplicationUserManager userManager)
        {
            //_context = new ApplicationDbContext();
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Invitation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SendEmailAsync(InvitationModel invitation)
        {
            

            IdentityMessage email = new IdentityMessage
            {
                Destination = invitation.Email,
                Subject = "You have been invited to join a DnD Campaign",
                Body = "In order to accept the invitation you must first visit our site and make sure that you arleady have a verified account. Then move on to Character Sheets option from the left menu bar and choose Create New. Feel free to create your own Character and don't forget to include the Campaign Id which is: " + invitation.Campaign_Id
            };

            await UserManager.EmailService.SendAsync(email);



            return RedirectToAction("View", "Campaign", new { id = invitation.Campaign_Id });
        }
    }
}