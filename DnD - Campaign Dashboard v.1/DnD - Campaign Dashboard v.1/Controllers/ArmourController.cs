using DnD___Campaign_Dashboard_v._1.Models.ArmorModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class ArmourController : Controller
    {
        private ArmorsModel armors;
        private ArmorModel armor;
        // GET: Armors
        [Authorize]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("equipment-categories/armor");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ArmorsModel>();
                    readTask.Wait();

                    armors = readTask.Result;
                }
                else
                {
                    armors = new ArmorsModel();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(armors.Equipment);
        }
        // GET: Armor
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
                    var readTask = result.Content.ReadAsAsync<ArmorModel>();
                    readTask.Wait();

                    armor = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(armor);
        }
    }
}