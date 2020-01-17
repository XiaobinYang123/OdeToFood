﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {   
            //  /trace.axd/1/2/3/4
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // * means match anything and replace it by variable pathInfo  

            // id Details/2
            // key will be query Details?id=2

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}