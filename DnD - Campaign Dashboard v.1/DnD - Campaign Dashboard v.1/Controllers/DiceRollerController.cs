using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class DiceRollerController : Controller
    {
        // returns view for the Jscript dicew roller
        public ActionResult Index()
        {
            return View();
        }
    }
}