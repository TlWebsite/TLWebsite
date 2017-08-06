// Copyright (c) Lakithu. All rights reserved.
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]
namespace TLWebsite.API
{
    using System.Web.Http;
    using TLWebsite.Data.Utils;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Mapper.CreateConfig();
        }
    }
}
