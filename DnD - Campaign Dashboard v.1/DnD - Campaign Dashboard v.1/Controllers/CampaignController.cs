using DnD___Campaign_Dashboard_v._1.Models;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendGrid;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Net;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    [Authorize]
    public class CampaignController : Controller
    {
        private ApplicationDbContext _context;
        
        //Instantiates a new instance of Db Context used to query the database
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
        
        //Allows users to create new campaign
        public ActionResult New()
        {
            var characters = _context.Characters.ToList();
            //Instantiates new campaign view model to pass multiple objects back to view
            var viewModel = new CampaignViewModel
            {
                Characters = characters,
                Campaign = new Campaign()
            };

            return View("New", viewModel);
            //return View();
        }

        //Method used when the new campaign form is submitted
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

        //Replaces the INDEX action, instead uses Tabs view to make UI more streamlined and intuitive
        public ActionResult Tabs(int id)
        {
            //Initialises objects to be loaded into view model
            var encounters = _context.Encounters.Where(e => e.CampaignId == id).ToList();
            InvitationModel invitation = new InvitationModel() { Campaign_Id = id, UserId = User.Identity.GetUserId() };
            Campaign campaign = _context.Campaigns.Find(id);
            var characterSheets = _context.Characters.Where(t => t.Campaign_Id == id).ToList();

            //Instrantiates new view model to pass objects to view
            CampaignViewModel campaignViewModel = new CampaignViewModel
            { 
                Campaign = campaign, 
                Characters = characterSheets, 
                Invitation = invitation, 
                Encounters = encounters 
            };

            return View(campaignViewModel);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = _context.Campaigns.Find(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(campaign).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("View", new { id = campaign.Id });
            }
            return View(campaign);
        }

        // GET: /Campaign/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = _context.Campaigns.Find(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // POST: /Campaign/Delete/5
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Campaign campaign = _context.Campaigns.Find(id);
            if (User.Identity.GetUserId() == campaign.DMUserId)
            {
                _context.Campaigns.Remove(campaign);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Error");
        }

        public ActionResult NewEncounter()
        {
            return View();
        }

    }
}