using System.Web.Http;
using AutoMapper;
using Snippr.API.App_Start;
using Snippr.Services.Mappers;

namespace Snippr.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ContainerConfig.Register();
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToIndexMapper>();
            });
        }
    }
}
