using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Snippr.Domain.Models;
using Snippr.Services.Codes;

namespace Snippr.API.Controllers
{
    public class CodesController : ApiController
    {
        private readonly ICodeService _codeService;

        public CodesController(ICodeService codeService)
        {
            _codeService = codeService;
        }

        [HttpGet]
        public List<CodeSnippet> Get()
        {
            return _codeService.GetCodeSnippets().ToList();
        } 
    }
}