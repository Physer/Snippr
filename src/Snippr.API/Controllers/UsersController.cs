using System;
using System.Web.Http;
using Snippr.Domain.Models.Business;

namespace Snippr.API.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] User newUser)
        {
            throw new NotImplementedException();   
        }
    }
}