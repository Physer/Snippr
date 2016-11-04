using Autofac;
using Snippr.Services;

namespace Snippr.API.App_Start
{
    public static class ContainerConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<SnipprModule>();
        }
    }
}