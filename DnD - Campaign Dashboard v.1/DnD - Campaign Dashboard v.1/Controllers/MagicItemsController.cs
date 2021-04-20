using DnD___Campaign_Dashboard_v._1.Models.MagicItemModelsApi;
using System;
using System.Net.Http;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class MagicItemsController : Controller
    {
        private MagicItemsModel magicItems;
        private MagicItemModel magicItem;
        // GET: MagicItems
        [Authorize]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("monsters");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MagicItemsModel>();
                    readTask.Wait();

                    magicItems = readTask.Result;
                }
                else 
                {
                    magicItems = new MagicItemsModel();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(magicItems.results);
        }
        // GET: MagicItem
        [Authorize]
        public ActionResult Details(string id)
        {


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                var responseTask = client.GetAsync("magic-items/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MagicItemModel>();
                    readTask.Wait();

                    magicItem = readTask.Result;
                }
                else 
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(magicItem);
        }
    }
}