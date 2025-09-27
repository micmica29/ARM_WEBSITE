using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.ProgramHead
{
    public class FacultyLoadingModel : PageModel
    {
        private readonly ILogger<FacultyLoadingModel> _logger;

        public FacultyLoadingModel(ILogger<FacultyLoadingModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
