using Snippr.Data.Clients;

namespace Snippr.Services.Data
{
    public class DataService : IDataService
    {
        private readonly IDataClient _dataClient;

        public DataService(IDataClient dataClient)
        {
            _dataClient = dataClient;
        }

        public void CreateIndex(string indexName) => _dataClient.CreateIndex(indexName);
    }
}
