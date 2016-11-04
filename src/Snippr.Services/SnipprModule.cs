using Autofac;
using Snippr.Data;

namespace Snippr.Services
{
    public class SnipprModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register other modules
            builder.RegisterModule<SnipprDataModule>();

            //Register services
        }
    }
}
