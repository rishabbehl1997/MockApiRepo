using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using MockResponseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MockResponseAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var builder = new ODataConventionModelBuilder();

            builder.EntitySet<odata>("MockApi");

            config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
        }
    }
}
