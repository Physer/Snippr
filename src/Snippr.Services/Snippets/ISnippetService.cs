using System.Collections.Generic;
using Snippr.Core.Models;

namespace Snippr.Services.Snippets
{
    public interface ISnippetService
    {
        IEnumerable<Snippet> GetAllSnippets();
        void CreateSnippet(Snippet snippet);
    }
}