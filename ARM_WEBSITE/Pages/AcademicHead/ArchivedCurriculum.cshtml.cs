using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.AcademicHead
{
    public class ArchivedCurriculumModel : PageModel
    {
        private readonly ILogger<ArchivedCurriculumModel> _logger;

        public ArchivedCurriculumModel(ILogger<ArchivedCurriculumModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
