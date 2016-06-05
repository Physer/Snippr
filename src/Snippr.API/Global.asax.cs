using System.Web.Http;

namespace Snippr.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ContainerConfig.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
