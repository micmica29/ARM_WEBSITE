using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.AcademicHead
{
    public class ScheduleOverviewModel : PageModel
    {
        private readonly ILogger<ScheduleOverviewModel> _logger;

        public ScheduleOverviewModel(ILogger<ScheduleOverviewModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
