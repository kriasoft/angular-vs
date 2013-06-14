// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteCollectionExtension.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Routing
{
    using System.Web.Routing;

    public static class RouteCollectionExtension
    {
        /// <summary>
        /// Provides a way to define routes for Razor web pages.
        /// </summary>
        /// <param name="routeCollection">The collection of routes.</param>
        /// <param name="name">The name of the route</param>
        /// <param name="url">The URL pattern for the route.</param>
        /// <param name="path">The virtual path of the web page.</param>
        /// <param name="defaults">The values to use if the URL does not contain all the parameters.</param>
        /// <param name="constraints">A regular expression that specifies valid values for a URL parameter.</param>
        public static void MapWebPageRoute(this RouteCollection routeCollection, string name, string url, string path, object defaults = null, object constraints = null)
        {
            routeCollection.Add(name, new Route(url, new RouteValueDictionary(defaults), new RouteValueDictionary(constraints), new WebPagesRouteHandler(path)));
        }
    }
}
