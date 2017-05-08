using System;
using System.Web.Http;
using Snippr.Domain;
using Snippr.Domain.Models.API;
using Snippr.Services.Users;

namespace Snippr.API.Controllers
{
    public class LoginController : ApiController
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Log a user in based on his e-mail address and password
        /// </summary>
        /// <param name="loginRequestModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Post(LoginRequestModel loginRequestModel)
        {
            try
            {
                var loginSuccessful = _userService.Login(loginRequestModel);
                if (loginSuccessful)
                    return Ok();
                return BadRequest(Constants.Exceptions.InvalidCredentials);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}