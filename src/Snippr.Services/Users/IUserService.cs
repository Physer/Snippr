using Snippr.Domain.Models.API;
using Snippr.Domain.Models.Business;

namespace Snippr.Services.Users
{
    public interface IUserService
    {
        void Login(User user);
        void Register(UserRequestModel userRequestModel);
    }
}