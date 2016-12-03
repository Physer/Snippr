using Nest;

namespace Snippr.Data.Clients
{
    public class DataClient : IDataClient
    {
        private readonly IElasticClient _elasticClient;

        public DataClient(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }
    }
}
