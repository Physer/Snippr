using Autofac;
using MongoDB.Driver;
using Snippr.Core.Repositories;
using Snippr.Data.Mongo.Repositories;

namespace Snippr.Data.Mongo
{
    public class MongoModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MongoClient>()
                .AsSelf()
                .WithParameter("connectionString", "mongodb://<dbuser>:<dbpassword>@ds036709.mlab.com:36709/snippr")
                .InstancePerRequest();

            builder.RegisterType<MongoRepository>().As<IRepository>();
        }
    }
}
