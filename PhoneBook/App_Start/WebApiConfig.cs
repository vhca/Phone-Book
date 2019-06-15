using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.Http;
using CommonDTO.Models_DTO;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Routing.Conventions;
using Microsoft.OData;
using Microsoft.OData.Edm;

namespace PhoneBook
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "api/v1.0",
                model: GetEdmModel());

            config.Routes.MapHttpRoute(
                name: "ResourceNotFound",
                routeTemplate: "api/v1.0/{controller}",
                defaults: new { controller = "UnrecognizedRoute", action = "ProcessUnrecognizedRoute" });

            config.EnsureInitialized();
        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder
            {
                Namespace = "PhoneBook",
                ContainerName = "PhoneBookContainer"
            };

            builder.EntitySet<ContactDTO>("Contact");
           // builder.EntitySet<PhoneDTO>("Phone");//.EntityType.HasKey(p => p.IdPhone); 

            return builder.GetEdmModel();
        }
    }
}
