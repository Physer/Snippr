using System;
using System.Security;

namespace Snippr.Domain.Models.Business
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public SecureString HashedPassword { get; set; }
    }
}
