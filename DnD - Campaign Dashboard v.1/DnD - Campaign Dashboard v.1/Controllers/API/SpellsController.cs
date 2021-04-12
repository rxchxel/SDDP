using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using DnD___Campaign_Dashboard_v._1.DTOs;
using DnD___Campaign_Dashboard_v._1.App_Start;

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
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetSpells()
        {
            var config = new MappingConfig().Configure();
            IMapper mapper = config.CreateMapper();
            var spells = _context.Spells.ToList();
            var spellsDtos = mapper.Map<List<SpellDTO>>(spells);
            return Ok(spellsDtos);
        }
    }
}
