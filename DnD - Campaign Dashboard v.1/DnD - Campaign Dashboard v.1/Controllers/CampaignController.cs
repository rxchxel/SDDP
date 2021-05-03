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
        [Authorize]
        public ActionResult Index()
        {
            
            var userId = User.Identity.GetUserId();

            var campaigns = _context.Campaigns.ToList();
            int count = campaigns.Count;
            for (int i = 0; i < count; i++)
            {
                
            }
            return View(campaigns.Where(t => t.DMUserId == userId));
            //return View();
        }
        [Authorize]
        public ActionResult New()
        {
            var characters = _context.Characters.ToList();
            var viewModel = new CampaignViewModel
            {
                Characters = characters,
                Campaign = new Campaign()
            };

            return View("New", viewModel);
            //return View();
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Campaign campaign)
        {
            campaign.DateCreated = DateTime.Now;
            campaign.DMUserId = User.Identity.GetUserId();
            _context.Campaigns.Add(campaign);
            _context.SaveChanges();

            return RedirectToAction("Index");
            //return View();
        }

        public ActionResult View(int id)
        {
            Campaign campaign = _context.Campaigns.Find(id);
            var characterSheets = _context.Characters.Where(t => t.Campaign_Id == id).ToList();
            CampaignViewModel campaignViewModel = new CampaignViewModel { Campaign = campaign, Characters = characterSheets };
            return View(campaignViewModel);
        }
    }
}