using System;
using System.Web.Mvc;

namespace Sample.Web.Application
{
    /// <summary>
    ///     Represents the filter configuration
    /// </summary>
    public static class FilterConfig
    {
        /// <summary>
        ///     Registeres the default filters
        /// </summary>
        /// <param name="filters">The collection of filters to populate</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            if (filters == null) 
                throw new ArgumentNullException("filters");
            filters.Add(new HandleErrorAttribute());
        }
    }
}