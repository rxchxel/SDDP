using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class WeaponsController : Controller
    {
        private ApplicationDbContext _context;
        public WeaponsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Weapons
        [Authorize]
        public ActionResult Index()
        {
            var weapons = _context.Weapons.ToList();
            return View(weapons);
        }
    }
}