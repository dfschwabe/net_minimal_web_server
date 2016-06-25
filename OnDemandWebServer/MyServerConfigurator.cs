using System.Web.Http;
using Owin;

namespace OnDemandWebServer
{
    public class MyServerConfigurator
    {
        public void Configuration(IAppBuilder builder)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            builder.UseWebApi(config);
        }
    }
}
