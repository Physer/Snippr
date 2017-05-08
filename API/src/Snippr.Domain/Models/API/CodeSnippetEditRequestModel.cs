using System;
using Snippr.Domain.Models.Business;

namespace Snippr.Domain.Models.API
{
    public class CodeSnippetEditRequestModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public Author OriginalAuthor { get; set; }
        public Author Editor { get; set; }
    }
}