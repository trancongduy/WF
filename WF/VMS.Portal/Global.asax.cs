﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace VMS.Portal
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.DefaultNamespaces.Add("VMS.WebApi.Controllers");

            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Clear();
            formatters.Add(new JsonMediaTypeFormatter());

            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;
            json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }
    }
}
