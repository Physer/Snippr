using System;

namespace Snippr.Domain.Models.Business
{
    public class User
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public string HashedPassword { get; set; }
    }
}
