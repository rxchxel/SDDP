using DnD___Campaign_Dashboard_v._1.Models.ArmorModelsApi;
using DnD___Campaign_Dashboard_v._1.Models.MagicItemModelsApi;
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
        //private MagicItemModel magicItem;
        // GET: Armors
        [Authorize]
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                //Set the Uri
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api");

                //Get Async the respornse of the request and store it
                var responseTask = client.GetAsync("equipment-categories/armor");
                //Wait to fetch the data
                responseTask.Wait();

                //From the response, take only the Result
                var result = responseTask.Result;
                //if statement: 200(OK) Status Code
                if (result.IsSuccessStatusCode)
                {
                    //Read Async all the data and fetch only those which are relate to our model
                    var readTask = result.Content.ReadAsAsync<ArmorsModel>();
                    //Wait to fetch the data
                    readTask.Wait();

                    //Store the results to the private property
                    armors = readTask.Result;

                    
                }
                else
                {
                    //Construct a new object of the speficic type
                    armors = new ArmorsModel();

                    //Add an error to Model State
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            //return to the View the specified model that occurs, from the API call
            return View(armors.Equipment);
        }
        // GET: Armor
        [Authorize]
        public ActionResult Details(string id)
        {


            using (var client = new HttpClient())
            {
                //Set the Uri
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                //Get Async the respornse of the request and store it 
                var responseTask = client.GetAsync("equipment/" + id);
                //Wait to fetch the data
                responseTask.Wait();

                //From the response, take only the Result
                var result = responseTask.Result;
                //if statement: 200(OK) Status Code
                if (result.IsSuccessStatusCode)
                {
                    //Read Async all the data and fetch only those which are relate to our model
                    var readTask = result.Content.ReadAsAsync<ArmorModel>();
                    //Wait to fetch the data
                    readTask.Wait();

                    //Store the results to the private property
                    armor = readTask.Result;
                }
                else if (!result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Details", "MagicItems", new { id });
                }
                else
                {
                    //Add an error to Model State
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            //return to the View the specified model that occurs, from the API call
            return View(armor);
        }
    }
}