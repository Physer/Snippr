using Autofac;
using Snippr.Data.Clients;

namespace Snippr.Data
{
    public class SnipprDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register types
            builder.RegisterType<DataClient>().As<IDataClient>();
        }
    }
}
