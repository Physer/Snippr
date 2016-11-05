using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Snippr.Domain.Models
{
    public class CodeSnippet : DatabaseModel
    {
        public string Code { get; set; }
        public int Upvotes { get; set; }
        [Required]
        public Author Author { get; set; }
        public IEnumerable<Category> Categories { get; set; } 
    }
}
