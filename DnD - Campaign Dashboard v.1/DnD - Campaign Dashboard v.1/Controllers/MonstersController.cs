using System;
using System.Net.Http;
using System.Web.Mvc;
using DnD___Campaign_Dashboard_v._1.Models.MonsterModelsApi;


namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    //SEE ARMOUR CONTROLLER FOR COMMENTS DUE TO REPEATED CONTENT
    public class MonstersController : Controller
    {
        private MonsterModel monster;
        // GET: Monsters
        [Authorize]
        public ActionResult Index()
        {
            MonstersModel monsters = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                //HTTP GET
                var responseTask = client.GetAsync("monsters");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MonstersModel>();
                    readTask.Wait();

                    monsters = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    monsters = new MonstersModel();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(monsters.results);
        }

        [Authorize]
        public ActionResult Details(string id)
        {


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                //HTTP GET
                var responseTask = client.GetAsync("monsters/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MonsterModel>();
                    readTask.Wait();

                    monster = readTask.Result;
                }
                else //web api sent error response 
                {
                    ////log response status here..

                    //spells = new Spells();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(monster);
        }
    }
}