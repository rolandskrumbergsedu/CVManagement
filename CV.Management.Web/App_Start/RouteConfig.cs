using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CV.Management.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Cv", action = "Profile" }
            );

            routes.MapRoute(
                name: "Language",
                url: "{controller}/{action}/{language}",
                defaults: new { controller = "Cv", action = "Profile", language = UrlParameter.Optional }
            );
        }
    }
}
