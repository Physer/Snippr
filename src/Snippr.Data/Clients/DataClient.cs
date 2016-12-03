using Nest;

namespace Snippr.Data.Clients
{
    public class DataClient : IDataClient
    {
        private readonly ElasticClient _elasticClient;

        public DataClient(ElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public void CreateIndex(string indexName) => _elasticClient.CreateIndex(indexName);
    }
}
