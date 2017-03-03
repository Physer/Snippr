using System;
using Nest;
using Snippr.Data.Models;

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
            //Create an Index, manually specificy the IndexModel if attributes are applied or manual mapping is necessary
            var result = _elasticClient.CreateIndex(indexName,
                x => x.Mappings(
                    m => m.Map<UserIndexModel>(y => y.AutoMap()))
                    );
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
