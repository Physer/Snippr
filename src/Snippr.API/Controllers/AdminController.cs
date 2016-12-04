using System;
using System.Web.Http;
using Snippr.Services.Data;

namespace Snippr.API.Controllers
{
    public class AdminController : ApiController
    {
        private readonly IIndexService _indexService;

        public AdminController(IIndexService indexService)
        {
            _indexService = indexService;
        }

        [HttpPost]
        [Route("api/admin/index/{indexname}")]
        public IHttpActionResult CreateIndex(string indexName)
        {
            if (string.IsNullOrWhiteSpace(indexName)) throw new ArgumentNullException();

            try
            {
                _indexService.CreateIndex(indexName);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("api/admin/index/{indexname}")]
        public IHttpActionResult DeleteIndex(string indexName)
        {
            if (string.IsNullOrWhiteSpace(indexName)) throw new ArgumentNullException();

            try
            {
                _indexService.DeleteIndex(indexName);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}