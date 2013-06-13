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
                .Include("~/scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/js/app").Include(
                "~/scripts/angular-ui-router.js",
                "~/scripts/app/app.js",
                "~/scripts/app/filters.js",
                "~/scripts/app/services.js",
                "~/scripts/app/directives.js",
                "~/scripts/app/controllers.js"));

            bundles.Add(new StyleBundle("~/css/app").Include("~/Styles/App.css"));
        }
    }
}