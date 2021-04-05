using Microsoft.Extensions.DependencyInjection;
using Snippr.Mongo;

namespace Snippr.Startup
{
    public static class ServiceConfigurationExtensions
    { 
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.Scan(configuration => configuration.FromAssemblyOf<IDataDependency>().AddClasses(classes => classes.AssignableTo<IDataDependency>()).AsImplementedInterfaces());
        }
    }
}
