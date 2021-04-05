using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Snippr.Application.Data;

namespace Snippr.Site.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository _repository;

        public string Message { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, 
            IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public void OnGet()
        {
            Message = _repository.Get();
        }
    }
}
