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
                //Set the Uri
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");

                //Get Async the respornse of the request and store it 
                var responseTask = client.GetAsync("equipment-categories/adventuring-gear");
                //Wait to fetch the data
                responseTask.Wait();

                //From the response, take only the Result
                var result = responseTask.Result;
                //if statement: 200(OK) Status Code
                if (result.IsSuccessStatusCode)
                {
                    //Read Async all the data and fetch only those which are relate to our model
                    var readTask = result.Content.ReadAsAsync<AdventureGearsModel>();
                    //Wait to fetch the data
                    readTask.Wait();

                    //Store the results to the private property
                    adventureGears = readTask.Result;
                }
                else
                {
                    //Construct a new object of the speficic type
                    adventureGears = new AdventureGearsModel();

                    //Add an error to Model State
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            //return to the View the specified model that occurs, from the API call
            return View(adventureGears.Equipment);
        }
        // GET: Weapon
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
                    var readTask = result.Content.ReadAsAsync<AdventureGearModel>();
                    //Wait to fetch the data
                    readTask.Wait();

                    //Store the results to the private property
                    adventureGear = readTask.Result;
                }
                else
                {
                    //Add an error to Model State
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            //return to the View the specified model that occurs, from the API call
            return View(adventureGear);
        }
    }
}