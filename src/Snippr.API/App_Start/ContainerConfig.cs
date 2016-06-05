using System;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Snippr.Services;

namespace Snippr.API
{
    public class ContainerConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // Register controllers
            builder.RegisterApiControllers(AppDomain.CurrentDomain.GetAssemblies());

            // Register modules in the project
            RegisterModules(builder);

            // Register the resolver
            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule<ServicesModule>();
        }
    }
}