using DnD___Campaign_Dashboard_v._1.Models.AdventureGearModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class AdventuringGearController : Controller
    {
        private AdventureGearsModel adventureGears;
        private AdventureGearModel adventureGear;
        // GET: Weapons
        [Authorize]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("equipment-categories/adventuring-gear");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<AdventureGearsModel>();
                    readTask.Wait();

                    adventureGears = readTask.Result;
                }
                else
                {
                    adventureGears = new AdventureGearsModel();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(adventureGears.Equipment);
        }
        // GET: Weapon
        [Authorize]
        public ActionResult Details(string id)
        {


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("equipment/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<AdventureGearModel>();
                    readTask.Wait();

                    adventureGear = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(adventureGear);
        }
    }
}