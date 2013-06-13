// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App
{
    using System.Web.Routing;

    using App.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;

            routes.MapWebPageRoute(
                name: "Default",
                url: "{*url}",
                path: "~/Index.cshtml");
        }
    }
}