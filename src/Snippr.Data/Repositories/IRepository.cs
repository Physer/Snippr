using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Snippr.Data.Repositories
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class, new();
        void AddRange<T>(IEnumerable<T> entities) where T : class, new();
        T Find<T>(params object[] keyValues) where T : class, new();
        T FirstOrDefault<T>(Func<T, bool> predicate) where T : class, new();
        IQueryable<T> GetMany<T>() where T : class, new();
        IQueryable<T> GetMany<T>(Func<T, bool> predicate) where T : class, new();
        void Remove<T>(T entity) where T : class, new();
        void RemoveRange<T>(IEnumerable<T> entities) where T : class, new();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}