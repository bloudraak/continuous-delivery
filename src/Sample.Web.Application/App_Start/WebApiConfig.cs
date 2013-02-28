using System;
using System.Web.Http;

namespace Sample.Web.Application
{
    /// <summary>
    ///     Represents the default api routes to configure
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        ///     Registers the api routes
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            if (config == null) 
                throw new ArgumentNullException("config");
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
                );
        }
    }
}