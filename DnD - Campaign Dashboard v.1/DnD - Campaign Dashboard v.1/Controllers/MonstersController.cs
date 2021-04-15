using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class MonstersController : Controller
    {
        private ApplicationDbContext _context;
        public MonstersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Monster
        public ActionResult Index()
        {
            var monsters = _context.Monsters.ToList();
            return View(monsters);
        }
    }
}