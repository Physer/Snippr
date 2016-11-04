using System.Collections.Generic;

namespace Snippr.Domain.Models
{
    public class CodeSnippet
    {
        public string Code { get; set; }
        public int Upvotes { get; set; }
        public Author Author { get; set; }
        public IEnumerable<Category> Categories { get; set; } 
    }
}
