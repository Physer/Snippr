using Autofac;
using Snippr.Data.Repositories;

namespace Snippr.Data
{
    public class SnipprDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SnipprRepository>().As<IRepository>();
        }
    }
}
