using System;
using System.Security;

namespace Snippr.Data.Models
{
    public class UserIndexModel : IndexModel
    {
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public SecureString HashedPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}
