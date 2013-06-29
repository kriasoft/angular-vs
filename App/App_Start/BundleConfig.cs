// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/angular", "//ajax.googleapis.com/ajax/libs/angularjs/1.1.5/angular.min.js")
                .Include("~/scripts/angular/angular.js"));

            bundles.Add(new ScriptBundle("~/js/app").Include(
                "~/scripts/angular/angular-ui-router.js",
                "~/scripts/app.js",
                "~/scripts/filters.js",
                "~/scripts/services.js",
                "~/scripts/directives.js",
                "~/scripts/controllers.js"));

            bundles.Add(new StyleBundle("~/css/app").Include("~/styles/app.css"));
        }
    }
}