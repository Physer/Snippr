using Nest;
using System;
using System.Collections.Generic;

namespace Snippr.Data.Models
{
    public class CodeSnippetIndexModel
    {
        [String]
        public Guid Id { get; set; }
        [String]
        public string Code { get; set; }
        [String]
        public int Upvotes { get; set; }
        public AuthorIndexModel Author { get; set; }
        public IEnumerable<CategoryIndexModel> Categories { get; set; }
    }
}
