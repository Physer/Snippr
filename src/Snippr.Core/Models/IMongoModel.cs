using System;

namespace Snippr.Core.Models
{
    public interface IMongoModel
    {
        Guid Id { get; set; }
    }
}
