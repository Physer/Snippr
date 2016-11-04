using System.Web.Http;
using System.Web.Mvc;
using Snippr.API.App_Start;

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
        }
    }
}
