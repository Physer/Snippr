using Snippr.Domain.Models.API;

namespace Snippr.Services.Users
{
    public interface IUserService
    {
        bool Login(LoginRequestModel loginRequestModel);
        void Register(UserRequestModel userRequestModel);
    }
}