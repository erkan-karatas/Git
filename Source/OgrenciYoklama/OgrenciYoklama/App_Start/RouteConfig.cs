using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OgrenciYoklama
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Login", action = "Index" });

            routes.MapRoute("Admin", "Admin/Ogrenci/OgrenciListele", new { Areas="Admin", controller = "Ogrenci", action = "OgrenciListele" });


        }
    }
}
