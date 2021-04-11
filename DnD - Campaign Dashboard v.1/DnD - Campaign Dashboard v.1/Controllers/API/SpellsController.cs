using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using DnD___Campaign_Dashboard_v._1.DTOs;
using AutoMapper.QueryableExtensions;

namespace DnD___Campaign_Dashboard_v._1.API
{
    public class SpellsController : ApiController
    {
        private ApplicationDbContext _context;

        //private MapperConfiguration config;
        public SpellsController()
        {
            //this.config = config;
            _context = new ApplicationDbContext();
        }
        //First API Method for testing this should work in thoery
        [Authorize]
        //[HttpGet]
        //public IEnumerable<SpellDTO> GetSpells()
        //{
        //    var dto = _context.Spells.ProjectTo<SpellDTO>(config);
        //    return dto;
        //}
        [HttpGet]
        public IEnumerable<Spell> GetSpells()
        {
            var spells = _context.Spells.ToList();
            return spells;
        }
    }
}
