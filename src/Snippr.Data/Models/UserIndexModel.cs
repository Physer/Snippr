using Nest;
using System;

namespace Snippr.Data.Models
{
    public class UserIndexModel : IndexModel
    {
        [String(Analyzer = "keyword")]
        public string EmailAddress { get; set; }
        public string HashedPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}
