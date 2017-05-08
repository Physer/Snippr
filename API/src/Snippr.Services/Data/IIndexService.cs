namespace Snippr.Services.Data
{
    public interface IIndexService
    {
        void CreateIndex(string indexName);
        void DeleteIndex(string indexName);
    }
}
