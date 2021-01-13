using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AplicacionBlanco
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{id2}/{id3}/{id4}",
                //url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, id2 = UrlParameter.Optional, id3 = UrlParameter.Optional, id4 = UrlParameter.Optional }
            );
            
        }
    }
}
