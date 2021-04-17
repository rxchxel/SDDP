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
    public class ArmoursAPIController : ApiController
    {
        private ApplicationDbContext _context;

        public ArmoursAPIController()
        {
            _context = new ApplicationDbContext();
        }

        //First API Method for testing this should work in thoery
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetArmours()
        {
            var config = new MappingConfig().Configure();
            IMapper mapper = config.CreateMapper();
            var armours = _context.Armours.ToList();
            var armoursDtos = mapper.Map<List<ArmourDTO>>(armours);
            return Ok(armoursDtos);
        }
    }
}
