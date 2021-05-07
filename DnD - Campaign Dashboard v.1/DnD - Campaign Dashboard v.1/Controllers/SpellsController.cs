using System;
using System.Net.Http;
using System.Web.Mvc;
using DnD___Campaign_Dashboard_v._1.Models.SpellModelsApi;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    //SEE ARMOUR CONTROLLER FOR COMMENTS DUE TO REPEATED CONTENT
    public class SpellsController : Controller
    {
        private Spells spells;
        private SpellInfoModel spellInfoModel;
        // GET: Spells
        [Authorize]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("spells");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Spells>();
                    readTask.Wait();

                    spells = readTask.Result;
                }
                else  
                {                 

                    spells = new Spells();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(spells.results);   
        }

        [Authorize]
        public ActionResult Details(string id)
        {

            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("spells/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<SpellInfoModel>();
                    readTask.Wait();

                    spellInfoModel = readTask.Result;
                }
                else 
                { 
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(spellInfoModel);
        }

    }
}