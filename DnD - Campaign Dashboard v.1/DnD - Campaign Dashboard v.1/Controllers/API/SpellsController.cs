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

        private readonly IMapper _mapper;
        public SpellsController()
        {
            _context = new ApplicationDbContext();
        }
        //public SpellsController(IMapper mapper)
        //{
        //    _mapper = mapper;
        //    _context = new ApplicationDbContext();
        //}
        //First API Method for testing this should work in thoery
        [Authorize]
        [HttpGet]
        //public string Get()
        //{
        //    return "Hello World!";
        //}
        public IHttpActionResult GetSpells()
        {
            var spells = _context.Spells.ToList();
            //var spellsDtos = new List<SpellDTO>();
            //_mapper.Map(spells, spellsDtos);
            return Ok(spells);
        }
    }
}
