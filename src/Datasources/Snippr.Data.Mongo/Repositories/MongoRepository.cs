using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;
using MongoDB.Driver;
using Snippr.Core.Models;
using Snippr.Core.Repositories;

namespace Snippr.Data.Mongo.Repositories
{
    public class MongoRepository : IRepository
    {
        private readonly IMongoDatabase _database;
        public MongoRepository(MongoClient client)
        {
            //TODO: Move the database name to a config file
            _database = client.GetDatabase("snippr");
        }
        public T FirstOrDefault<T>(Func<T, bool> predicate) where T : class, IMongoModel, new()
        {
            return GetCollection<T>().AsQueryable().FirstOrDefault(predicate);
        }

        public IQueryable<T> GetMany<T>() where T : class, IMongoModel, new()
        {
            return GetCollection<T>().AsQueryable();
        }

        public IQueryable<T> GetMany<T>(Func<T, bool> predicate) where T : class, IMongoModel, new()
        {
            return GetCollection<T>().AsQueryable().Where(predicate).AsQueryable();
        }

        public void Add<T>(T entity) where T : class, IMongoModel, new()
        {
            if(entity != null)
                GetCollection<T>().InsertOne(entity);
        }

        public void AddRange<T>(IEnumerable<T> entities) where T : class, IMongoModel, new()
        {
            if(entities.Any())
                GetCollection<T>().InsertMany(entities);
        }

        public void Remove<T>(T entity) where T : class, IMongoModel, new()
        {
            if (entity != null)
            {
                var filter = Builders<T>.Filter.Eq("_id", entity.Id);
                GetCollection<T>().DeleteOne(filter);
            }
        }

        private IMongoCollection<T> GetCollection<T>()
        {
            return _database.GetCollection<T>(typeof (T).Name.Pluralize());
        }
    }
}
