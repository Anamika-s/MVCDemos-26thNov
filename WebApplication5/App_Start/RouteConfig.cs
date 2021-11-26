﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
             name: "StudentRoute",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Student", action = "GetDetails", id = UrlParameter.Optional }
         );
            routes.MapRoute(
               name: "FirstRoute",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "First", action = "Action1", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
