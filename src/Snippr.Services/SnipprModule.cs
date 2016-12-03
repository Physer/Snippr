using Autofac;
using Snippr.Data;
using Snippr.Services.Codes;
using Snippr.Services.Data;

namespace Snippr.Services
{
    public class SnipprModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register other modules
            builder.RegisterModule<SnipprDataModule>();

            //Register services
            builder.RegisterType<CodeService>().AsImplementedInterfaces();
            builder.RegisterType<DataService>().AsImplementedInterfaces();
        }
    }
}
