using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyContactPage
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Fever",
                url: "FeverCheck",
                defaults: new { controller = "Home", action = "FeverCheck", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "GuessingGame",
                url: "GuessingGame",
                defaults: new { controller = "Home", action = "GuessGame", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
