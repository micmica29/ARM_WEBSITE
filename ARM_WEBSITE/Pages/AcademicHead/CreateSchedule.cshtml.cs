using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.AcademicHead
{
    public class CreateScheduleModel : PageModel
    {

        private readonly ILogger<CreateScheduleModel> _logger;

        public CreateScheduleModel(ILogger<CreateScheduleModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}
