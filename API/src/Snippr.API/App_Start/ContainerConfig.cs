using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Snippr.Services;

namespace Snippr.API
{
    public static class ContainerConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<SnipprModule>();


            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            var config = GlobalConfiguration.Configuration;
            builder.RegisterWebApiFilterProvider(config);
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}