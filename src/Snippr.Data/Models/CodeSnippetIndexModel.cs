using Nest;
using System;
using System.Collections.Generic;

namespace Snippr.Data.Models
{
    public class CodeSnippetIndexModel
    {
        [Keyword]
        public Guid Id { get; set; }
        [Text]
        public string Code { get; set; }
        [Keyword]
        public int Upvotes { get; set; }
        public AuthorIndexModel Author { get; set; }
        public IEnumerable<CategoryIndexModel> Categories { get; set; }
    }
}
