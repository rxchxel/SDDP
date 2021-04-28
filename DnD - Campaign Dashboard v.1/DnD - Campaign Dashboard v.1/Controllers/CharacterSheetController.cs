using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using System.Net;
using System.Data.Entity;

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
            //return View();
        }

        public ActionResult New()
        {
            var viewModel = new Character();
            return View(viewModel);
            //return View();
        }

        
        [HttpPost]
        public ActionResult Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index", "CharacterSheet");
            //return View();
        }

        public ActionResult Details(int id)
        {
            Character character = _context.Characters.Find(id);
            return View(character);
            //return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = _context.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(character).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = character.Id});
            }
            return View(character);
        }

        // GET: /Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = _context.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = _context.Characters.Find(id);
            _context.Characters.Remove(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}