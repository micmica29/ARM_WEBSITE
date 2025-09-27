using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.ProgramHead
{
    public class AddFacultyModel : PageModel
    {
        private readonly ILogger<AddFacultyModel> _logger;

        public AddFacultyModel(ILogger<AddFacultyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
