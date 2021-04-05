using Snippr.Application.Data;

namespace Snippr.Mongo
{
    public class MongoRepository : IRepository, IDataDependency
    {
        public string Get() => "Mongo dependency";
    }
}
