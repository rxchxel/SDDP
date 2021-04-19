using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class CharacterSheetController : Controller
    {
        private ApplicationDbContext _context;

        public CharacterSheetController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: CharacterSheet
        public ActionResult Index()
        {
            var characterSheets = _context.Characters.ToList();
            return View(characterSheets);
        }

        public ActionResult New()
        {
            var viewModel = new Character();
            return View(viewModel);
        }

        
        [HttpPost]
        public ActionResult Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index","CharacterSheet");
        }
    }
}