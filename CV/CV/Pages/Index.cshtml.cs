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

        public IActionResult OnGetDownloadCVODT()
        {
            return File("/downloadableFiles/CV - Jacob Ravn 2023.odt", "application/octet-stream", "CV - Jacob Ravn 2023.odt");
        }

        public IActionResult OnGetDownloadCVPDF()
        {
            return File("/downloadableFiles/CV - Jacob Ravn 2023.pdf", "application/octet-stream", "CV - Jacob Ravn 2023.pdf");
        }

        public IActionResult OnGetDownloadBevisDiploma()
        {
            return File("/downloadableFiles/BevisDiploma.PDF", "application/octet-stream", "BevisDiploma.PDF");
        }

        public IActionResult OnGetDownloadRecommendation()
        {
            return File("/downloadableFiles/Jacob Ravn - udtalelse november 2021 .pdf", "application/octet-stream", "Jacob Ravn - udtalelse november 2021 .pdf");
        }
    }
}