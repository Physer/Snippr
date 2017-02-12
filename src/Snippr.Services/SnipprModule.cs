using Autofac;
using Snippr.Data;
using Snippr.Services.Code_snippets;
using Snippr.Services.Data;
using Snippr.Services.Users;

namespace Snippr.Services
{
    public class SnipprModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register other modules
            builder.RegisterModule<SnipprDataModule>();

            //Register services
            builder.RegisterType<CodeSnippetService>().AsImplementedInterfaces();
            builder.RegisterType<IndexService>().AsImplementedInterfaces();
            builder.RegisterType<UserService>().AsImplementedInterfaces();
        }
    }
}
