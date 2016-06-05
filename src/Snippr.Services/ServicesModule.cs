using Autofac;
using Snippr.Data.Mongo;
using Snippr.Services.Snippets;

namespace Snippr.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<MongoModule>();

            builder.RegisterType<SnippetService>().As<ISnippetService>();
        }
    }
}
