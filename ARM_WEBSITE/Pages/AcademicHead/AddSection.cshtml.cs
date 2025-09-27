using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.AcademicHead
{
    public class AddSectionModel : PageModel
    {
        private readonly ILogger<AddSectionModel> _logger;

        public AddSectionModel(ILogger<AddSectionModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
