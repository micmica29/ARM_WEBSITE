using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.ProgramHead
{
    public class NonWorkingHoursModel : PageModel
    {
        private readonly ILogger<NonWorkingHoursModel> _logger;

        public NonWorkingHoursModel(ILogger<NonWorkingHoursModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
