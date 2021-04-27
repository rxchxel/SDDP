using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class EncounterController : Controller
    {
        private ApplicationDbContext _context;
        public EncounterController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Encounter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddEncounter(Encounter encounter)
        {
            _context.Encounters.Add(encounter);
            _context.SaveChanges();

            return View("Index");
        }
    }
}