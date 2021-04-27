using DnD___Campaign_Dashboard_v._1.Models;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class CampaignController : Controller
    {
        private ApplicationDbContext _context;

        public CampaignController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Campaign
        public ActionResult Index()
        {
            var campaigns = _context.Campaigns.ToList();
            return View(campaigns);
        }
        public ActionResult New()
        {
            var characters = _context.Characters.ToList();
            var viewModel = new CampaignViewModel 
            {
                Characters = characters,
                Campaign = new Campaign()
            };

            return View("New", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Campaign campaign)
        {
            campaign.DMUserId = User.Identity.GetUserId();
            _context.Campaigns.Add(campaign);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}