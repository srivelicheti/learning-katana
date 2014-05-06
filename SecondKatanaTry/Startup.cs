using Microsoft.Owin;
using Owin;
using SecondKatanaTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly:OwinStartup(typeof(Startup))]
namespace SecondKatanaTry
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseNancy();

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            //config.Routes.MapHttpRoute("Default", "{controller}/{bugId}", new { controller = "Bugs", bugId = RouteParameter.Optional });
            config.Routes.MapHttpRoute("bugs", "api/{controller}");
            config.EnableSystemDiagnosticsTracing();
            app.UseWebApi(config);

            app.UseNancy();
        }

        
    }
}