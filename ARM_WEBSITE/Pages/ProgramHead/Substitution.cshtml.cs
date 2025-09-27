using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.ProgramHead
{
    public class SubstitutionModel : PageModel
    {
        private readonly ILogger<SubstitutionModel> _logger;

        public SubstitutionModel(ILogger<SubstitutionModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
