using System;
using System.Collections.Generic;
using System.Linq;
using Snippr.Core.Models;

namespace Snippr.Core.Repositories
{
    public interface IRepository
    {
        T FirstOrDefault<T>(Func<T, bool> predicate) where T : class, IMongoModel, new();
        IQueryable<T> GetMany<T>() where T : class, IMongoModel, new();
        IQueryable<T> GetMany<T>(Func<T, bool> predicate) where T : class, IMongoModel, new();
        void Add<T>(T entity) where T : class, IMongoModel, new();
        void AddRange<T>(IEnumerable<T> entities) where T : class, IMongoModel, new();
        void Remove<T>(T entity) where T : class, IMongoModel, new();
    }
}
