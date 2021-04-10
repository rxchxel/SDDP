using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DnD___Campaign_Dashboard_v._1.API
{
    public class SpellsController : ApiController
    {
        private ApplicationDbContext _context;
        public SpellsController()
        {
            _context = new ApplicationDbContext();
        }
        //First API Method for testing this should work in thoery
        public IEnumerable<Spell> GetSpells()
        {
            return _context.Spells.ToList();
        }
    }
}
