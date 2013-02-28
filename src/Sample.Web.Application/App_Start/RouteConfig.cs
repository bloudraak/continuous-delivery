using System.Web.Mvc;
using System.Web.Routing;

namespace Sample.Web.Application
{
    /// <summary>
    ///     Represents the route configuration for this application
    /// </summary>
    public static class RouteConfig
    {
        /// <summary>
        ///     Registers the routes for this application
        /// </summary>
        /// <param name="routes">The routes to configure</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}