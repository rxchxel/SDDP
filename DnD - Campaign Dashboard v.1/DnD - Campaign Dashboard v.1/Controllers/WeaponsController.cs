using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class WeaponsController : Controller
    {
        // GET: Weapons
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}