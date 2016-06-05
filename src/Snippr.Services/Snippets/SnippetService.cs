using System.Collections.Generic;
using Snippr.Core.Models;
using Snippr.Core.Repositories;

namespace Snippr.Services.Snippets
{
    public class SnippetService : ISnippetService
    {
        private readonly IRepository _repository;

        public SnippetService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Snippet> GetAllSnippets()
        {
            return _repository.GetMany<Snippet>();
        }

        public void CreateSnippet(Snippet snippet)
        {
            _repository.Add(snippet);
        }
    }
}
