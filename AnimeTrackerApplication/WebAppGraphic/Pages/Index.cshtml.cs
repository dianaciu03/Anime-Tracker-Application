using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppGraphic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            //if(HttpContext.Session.Get("Dummy") is null)
            //{
            //    HttpContext.Session.SetString("Dummy", "Some data");
            //}

            return Page();
        }
    }
}