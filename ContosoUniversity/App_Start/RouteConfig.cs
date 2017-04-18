using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ContosoUniversity
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            //Examples of how the routing works:
            //http//localhost:1230/Instructor/Index/1?courseID=2021
            //In this example:
            //Instructor = controller
            //Index = Action
            //1 = ID
            //?courseID=2021 = query string value
            //The link above will also work if you pass in "ID" as a query string value, which would look like = ?id=1&CourseID=2021
            
        }
    }
}
