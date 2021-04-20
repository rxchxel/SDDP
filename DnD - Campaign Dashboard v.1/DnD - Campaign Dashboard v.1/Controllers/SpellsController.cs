using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class SpellsController : Controller
    {
        // GET: Spells
        [Authorize]
        public ActionResult Index()
        {
<<<<<<< Updated upstream
            return View();
=======

            Spells spells = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");
                              
                //HTTP GET
                var responseTask = client.GetAsync("spells");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Spells>();
                    readTask.Wait();

                    spells = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    spells = new Spells();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(spells.results);   
        }


        public ActionResult Details(string id)
        {

            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co");

                //HTTP GET
                var responseTask = client.GetAsync(id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<SpellInfoModel>();
                    readTask.Wait();

                    spellInfoModel = readTask.Result;
                }
                else //web api sent error response 
                {
                    ////log response status here..

                    //spells = new Spells();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(spellInfoModel);
>>>>>>> Stashed changes
        }
    }
}