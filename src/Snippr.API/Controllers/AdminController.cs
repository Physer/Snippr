using System;
using System.Web.Http;
using Snippr.Services.Data;

namespace Snippr.API.Controllers
{
    public class AdminController : ApiController
    {
        private readonly IDataService _dataService;

        public AdminController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        [Route("api/admin/index/{indexname}")]
        public void CreateIndex(string indexName)
        {
            if (string.IsNullOrWhiteSpace(indexName)) throw new ArgumentNullException();

            _dataService.CreateIndex(indexName);
        }
    }
}