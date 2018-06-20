using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidPlace
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*
            routes.MapRoute(
                name: "Release",
                url: "Test/Release/{year}/{month}",
                defaults: new { controller = "Test", action = "release" },
                constraints: new { year = "2017|2018", month = @"^(0?[1-9]|1[012])$"}
            );

            routes.MapRoute(
                name: "Test2",
                url: "Test/ex2/{pageIndex}/{sortby}",
                defaults: new { controller = "Test", action = "ex2" }
            );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
