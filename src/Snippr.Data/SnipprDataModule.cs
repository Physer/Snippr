using Autofac;
using Nest;
using Snippr.Data.Clients;
using Snippr.Data.Repositories;

namespace Snippr.Data
{
    public class SnipprDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register types
            builder.RegisterType<ElasticClient>().AsSelf();
            builder.RegisterType<IndexClient>().AsImplementedInterfaces();
            builder.RegisterType<ElasticRepository>().AsImplementedInterfaces();
        }
    }
}
