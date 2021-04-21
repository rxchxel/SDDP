using DnD___Campaign_Dashboard_v._1.Models;
using DnD___Campaign_Dashboard_v._1.Models.WeaponModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class WeaponsController : Controller
    {
        private WeaponsModel weapons;
        private WeaponModel weapon;
        // GET: Weapons
        [Authorize]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("equipment-categories/weapon");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<WeaponsModel>();
                    readTask.Wait();

                    weapons = readTask.Result;
                }
                else
                {
                    weapons = new WeaponsModel();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(weapons.Equipment);
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
                    var readTask = result.Content.ReadAsAsync<WeaponModel>();
                    readTask.Wait();

                    weapon = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(weapon);
        }
    }
}