using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace pesebrera
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();            
            config.Formatters.JsonFormatter.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(name: "Animal", routeTemplate: "api/{controller}/{name}", defaults: new { name = RouteParameter.Optional });
            config.EnableCors();
        }
    }
}