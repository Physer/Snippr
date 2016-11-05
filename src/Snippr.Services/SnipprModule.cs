using Autofac;
using Snippr.Data;
using Snippr.Services.Codes;

namespace Snippr.Services
{
    public class SnipprModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register other modules
            builder.RegisterModule<SnipprDataModule>();

            //Register services
            builder.RegisterType<CodeService>().As<ICodeService>();
        }
    }
}
