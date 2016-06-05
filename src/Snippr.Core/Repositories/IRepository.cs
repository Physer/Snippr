using System;
using System.Collections.Generic;
using System.Linq;

namespace Snippr.Core.Repositories
{
    public interface IRepository
    {
        T Find<T>(params object[] keyValues) where T : class;
        T FirstOrDefault<T>(Func<T, bool> predicate) where T : class, new();
        IQueryable<T> GetMany<T>() where T : class, new();
        IQueryable<T> GetMany<T>(Func<T, bool> predicate) where T : class, new();
        void Add<T>(T entity) where T : class, new();
        void AddRange<T>(IEnumerable<T> entities) where T : class, new();
        void Remove<T>(T entity) where T : class, new();
        void RemoveRange<T>(IEnumerable<T> entities) where T : class, new();
    }
}
