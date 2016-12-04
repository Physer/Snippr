using System.Collections.Generic;

namespace Snippr.Domain.Models
{
    public class Author
    {
        public string Username { get; set; } = Constants.ModelConstants.Anonymous;
        public IEnumerable<CodeSnippet> OwnedCodeSnippets { get; set; }
    }
}
