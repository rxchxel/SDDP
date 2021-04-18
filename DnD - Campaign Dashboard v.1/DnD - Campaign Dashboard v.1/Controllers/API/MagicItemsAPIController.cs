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
    public class MagicItemsAPIController : ApiController
    {
        private ApplicationDbContext _context;

        public MagicItemsAPIController()
        {
            _context = new ApplicationDbContext();
        }

        //First API Method for testing this should work in thoery
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetMagicItems()
        {
            var config = new MappingConfig().Configure();
            IMapper mapper = config.CreateMapper();
            var MagicItems = _context.MagicItems.ToList();
            var MagicItemsDtos = mapper.Map<List<MagicItemDTO>>(MagicItems);
            return Ok(MagicItemsDtos);
        }
    }
}
