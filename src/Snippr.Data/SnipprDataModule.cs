using Autofac;
using Snippr.Data.Repositories;

namespace Snippr.Data
{
    public class SnipprDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SnipprContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SnipprRepository>().AsImplementedInterfaces();
        }
    }
}
