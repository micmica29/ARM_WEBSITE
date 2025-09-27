using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.AcademicHead
{
    public class CurriculumModel : PageModel
    {
        private readonly ILogger<CurriculumModel> _logger;

        public CurriculumModel(ILogger<CurriculumModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
