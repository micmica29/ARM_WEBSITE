using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.ProgramHead
{
    public class AssignFacultyModel : PageModel
    {
        private readonly ILogger<AssignFacultyModel> _logger;

        public AssignFacultyModel(ILogger<AssignFacultyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
