using AutoMapper;
using DnD___Campaign_Dashboard_v._1.DTOs;
using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DnD___Campaign_Dashboard_v._1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<Spell, SpellDTO>());
            //IMapper mapper = new Mapper(config);
            
        }
    }
}
