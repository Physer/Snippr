using System;

namespace Snippr.Domain.Models.API
{
    public class UserRequestModel
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
    }
}
