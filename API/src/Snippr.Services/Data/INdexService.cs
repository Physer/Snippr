using Snippr.Data.Clients;

namespace Snippr.Services.Data
{
    public class IndexService : IIndexService
    {
        private readonly IIndexClient _indexClient;

        public IndexService(IIndexClient indexClient)
        {
            _indexClient = indexClient;
        }

        public void CreateIndex(string indexName) => _indexClient.CreateIndex(indexName);
        public void DeleteIndex(string indexName) => _indexClient.DeleteIndex(indexName);
    }
}
