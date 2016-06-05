using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using Snippr.Core.Repositories;

namespace Snippr.Data.Mongo.Repositories
{
    public class MongoRepository : IRepository
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        public MongoRepository(MongoClient client)
        {
            _client = client;
            //TODO: Move the database name to a config file
            _database = client.GetDatabase("snippr");
        }

        public T Find<T>(params object[] keyValues) where T : class
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault<T>(Func<T, bool> predicate) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMany<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMany<T>(Func<T, bool> predicate) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Add<T>(T entity) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void AddRange<T>(IEnumerable<T> entities) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(T entity) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public void RemoveRange<T>(IEnumerable<T> entities) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
