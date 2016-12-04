using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Snippr.API.App_Start;
using Snippr.Services.Mappers;

namespace Snippr.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
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
