using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Snippr.Application.Data;
using Snippr.Application.Options;
using System;

namespace Snippr.Mongo
{
    public class MongoRepository : IRepository, IDataDependency
    {
        private readonly MongoClient _mongoClient;

        public MongoRepository(IOptions<MongoOptions> mongoOptions)
        {
            if (string.IsNullOrWhiteSpace(mongoOptions?.Value?.ConnectionString))
                throw new ArgumentNullException(nameof(mongoOptions.Value.ConnectionString), "No MongoDB connection string located");

            _mongoClient = new MongoClient(mongoOptions.Value.ConnectionString);
        }

        public string Get() => "Mongo dependency";
    }
}
