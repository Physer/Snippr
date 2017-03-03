using System;
using System.Web.Http;
using Snippr.Domain.Models.API;
using Snippr.Services.Users;

namespace Snippr.API.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] UserRequestModel userRequestModel)
        {
            try
            {
                _userService.Register(userRequestModel);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}