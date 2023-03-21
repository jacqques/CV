using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CV.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetDownloadCV()
        {
            Console.WriteLine("hertil");
            return File("/downloadableFiles/CV - Jacob Ravn 2023.odt", "application/octet-stream", "CV - Jacob Ravn 2023.odt");
        }
    }
}