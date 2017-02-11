using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using Snippr.Domain.Models.API;
using Snippr.Domain.Models.Business;
using Snippr.Services.Code_snippets;

namespace Snippr.API.Controllers
{
    public class CodeSnippetsController : ApiController
    {
        private readonly ICodeSnippetService _codeService;

        public CodeSnippetsController(ICodeSnippetService codeService)
        {
            _codeService = codeService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                return Content(HttpStatusCode.OK, _codeService.GetCodeSnippets().ToList());
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] CodeSnippet codeSnippet)
        {
            try
            {
                _codeService.AddCodeSnippet(codeSnippet);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody] CodeSnippetEditRequestModel editRequestModel)
        {
            try
            {
                _codeService.EditCodeSnippet(editRequestModel);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}