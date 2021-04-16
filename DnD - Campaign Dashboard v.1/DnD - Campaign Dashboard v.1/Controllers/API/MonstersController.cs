using AutoMapper;
using DnD___Campaign_Dashboard_v._1.App_Start;
using DnD___Campaign_Dashboard_v._1.DTOs;
using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DnD___Campaign_Dashboard_v._1.Controllers.API
{
    public class MonstersController : ApiController
    {
        private ApplicationDbContext _context;

        public MonstersController()
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
            var monsters = _context.Monsters.ToList();
            var mosntersDtos = mapper.Map<List<MonsterDTO>>(monsters);
            return Ok(mosntersDtos);
        }
    }
}
