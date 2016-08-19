using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;

namespace Mediagral.Person.Config
{
    public class ContactRouting
    {
        public const string areaName = "Contact";
        public IRouteBuilder addRoutes(IRouteBuilder routeCollection)
        {
            routeCollection.MapRoute(
                name: "ContactAction",
                template: areaName + "/{controller}/{action}/{id?}",
                defaults: new { area = areaName, controller = "Home" },
                constraints: new { id = @"\d+" }
                );
            routeCollection.MapRoute(
                name: "ContactApi",
                template: "Api/" + areaName + "/{controller}/{action}/{id?}",
                defaults: new { area = areaName, controller = "Api" },
                constraints: new { id = @"\d+" }
                );
            routeCollection.MapRoute(
                name: "ContactArea", 
                template: areaName + "/{controller}/{action}",
                defaults: new { area = areaName, controller = "Home", action = "Index"}
                );
            return routeCollection;
        }
    }
}