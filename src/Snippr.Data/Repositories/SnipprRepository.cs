using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Snippr.Data.Repositories
{
    public class SnipprRepository : IRepository
    {
        private readonly SnipprContext _context;

        public SnipprRepository(SnipprContext context)
        {
            _context = context;
        }

        #region Fetch methods
        public T Find<T>(params object[] keyValues) where T : class, new()
        {
            return _context.Set<T>().Find(keyValues);
        }

        public T FirstOrDefault<T>(Func<T, bool> predicate) where T : class, new()
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public IQueryable<T> GetMany<T>() where T : class, new()
        {
            return _context.Set<T>().AsQueryable();
        }

        public IQueryable<T> GetMany<T>(Func<T, bool> predicate) where T : class, new()
        {
            return _context.Set<T>().Where(predicate).AsQueryable();
        }
        #endregion

        #region Add & remove methods
        public void Add<T>(T entity) where T : class, new()
        {
            if (entity != null)
                _context.Set<T>().Add(entity);
        }

        public void AddRange<T>(IEnumerable<T> entities) where T : class, new()
        {
            if (entities != null)
                _context.Set<T>().AddRange(entities);
        }

        public void Remove<T>(T entity) where T : class, new()
        {
            if (entity != null)
                _context.Set<T>().Remove(entity);
        }

        public void RemoveRange<T>(IEnumerable<T> entities) where T : class, new()
        {
            if (entities != null)
                _context.Set<T>().RemoveRange(entities);
        }
        #endregion

        #region Save methods
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
        #endregion
    }
}
