using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Http;
using Snippr.Domain.Helpers;
using Snippr.Domain.Models;
using Snippr.Services.Codes;

namespace Snippr.API.Controllers
{
    public class SnippetsController : ApiController
    {
        private readonly ICodeService _codeService;

        public SnippetsController(ICodeService codeService)
        {
            _codeService = codeService;
        }

        [HttpGet]
        public List<CodeSnippet> Get()
        {
            return _codeService.GetCodeSnippets().ToList();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] CodeSnippet codeSnippet)
        {
            try
            {
                _codeService.AddCodeSnippet(codeSnippet);
                return Ok();
            }
            catch (DbEntityValidationException entityValidationException)
            {
                return InternalServerError(DbEntityValidationExceptionHelper.ConvertToReadableException(entityValidationException));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}