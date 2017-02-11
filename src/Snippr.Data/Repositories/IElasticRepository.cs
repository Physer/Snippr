using System;
using System.Collections.Generic;
using Snippr.Data.Models;

namespace Snippr.Data.Repositories
{
    public interface IElasticRepository
    {
        void Add<T>(T indexModel, string index = null) where T : IndexModel, new();
        void Delete<T>(T indexModel, string index = null) where T : IndexModel, new();
        IEnumerable<T> GetAll<T>(string index = null) where T : IndexModel, new();
        void Edit<T>(T indexModel, string index = null) where T : IndexModel, new();
        T Get<T>(Guid id, string index = null) where T : IndexModel, new();
        IEnumerable<T> Search<T>(object property, string searchTerm, string index = null) where T : IndexModel, new();
    }
}