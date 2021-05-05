using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace DnD___Campaign_Dashboard_v._1
{
    public static class WebApiConfig
    {
        //This files serves as a configuration file for the original API query method we used. We have left it in for evidence.
        //The method below registers the API when compiles.
        public static void Register(HttpConfiguration config)
        {
            //Below: Allows for one to specify the format that returned data is pushed. Overwrites
            //defualt XML return type and replaces it wiht only json.
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //Correctly indents the returned JSON
            settings.Formatting = Formatting.Indented;

            config.MapHttpAttributeRoutes();

            //Defines routing information of the API
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
