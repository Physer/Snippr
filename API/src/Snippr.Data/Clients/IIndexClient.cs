namespace Snippr.Data.Clients
{
    public interface IIndexClient
    {
        void CreateIndex(string indexName);
        void DeleteIndex(string indexName);
    }
}
