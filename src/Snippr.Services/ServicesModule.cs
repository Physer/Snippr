using Autofac;
using Snippr.Data.Mongo;

namespace Snippr.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<MongoModule>();
        }
    }
}
