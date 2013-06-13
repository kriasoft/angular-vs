// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebPagesRouteHandler.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Routing
{
    using System.Web;
    using System.Web.Routing;
    using System.Web.WebPages;

    public class WebPagesRouteHandler : IRouteHandler
    {
        private readonly string virtualPath;

        private Route routeVirtualPath;

        public WebPagesRouteHandler(string virtualPath)
        {
            this.virtualPath = virtualPath;
        }

        private Route RouteVirtualPath
        {
            get
            {
                if (this.routeVirtualPath == null)
                {
                    this.routeVirtualPath = new Route(this.virtualPath.Substring(2), this);
                }

                return this.routeVirtualPath;
            }
        }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            var substitutedVirtualPath = this.GetSubstitutedVirtualPath(requestContext);
            var index = substitutedVirtualPath.IndexOf('?');
            
            if (index != -1)
            {
                substitutedVirtualPath = substitutedVirtualPath.Substring(0, index);
            }

            requestContext.HttpContext.SetRouteValue(requestContext.RouteData.Values);
            return WebPageHttpHandler.CreateFromVirtualPath(substitutedVirtualPath);
        }

        public string GetSubstitutedVirtualPath(RequestContext requestContext)
        {
            var virtPath = this.RouteVirtualPath.GetVirtualPath(requestContext, requestContext.RouteData.Values);
            
            if (virtPath == null)
            {
                return this.virtualPath;
            }

            return "~/" + virtPath.VirtualPath;
        }
    }
}
