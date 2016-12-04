using System;
using Nest;

namespace Snippr.Data.Clients
{
    public class IndexClient : IIndexClient
    {
        private readonly ElasticClient _elasticClient;

        public IndexClient(ElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public void CreateIndex(string indexName)
        {
            var result = _elasticClient.CreateIndex(indexName);
            if(!result.IsValid)
                throw new Exception(result.ServerError.Error.Reason);
        }

        public void DeleteIndex(string indexName)
        {
            var result = _elasticClient.DeleteIndex(indexName);
            if(!result.IsValid)
                throw new Exception(result.ServerError.Error.Reason);
        }
    }
}
