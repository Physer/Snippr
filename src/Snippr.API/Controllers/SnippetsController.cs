using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Snippr.Core.Models;
using Snippr.Services.Snippets;

namespace Snippr.API.Controllers
{
    public class SnippetsController : ApiController
    {
        private readonly ISnippetService _snippetService;
        public SnippetsController(ISnippetService snippetService)
        {
            _snippetService = snippetService;
        }

        [HttpGet]
        public List<Snippet> Get()
        {
            return _snippetService.GetAllSnippets().ToList();
        }

        [HttpPost]
        public void Post([FromBody] Snippet snippet)
        {
            _snippetService.CreateSnippet(snippet);
        }
    }
}