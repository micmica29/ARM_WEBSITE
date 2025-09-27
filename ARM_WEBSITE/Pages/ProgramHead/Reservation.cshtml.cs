using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARM_WEBSITE.Pages.ProgramHead
{
    public class ReservationModel : PageModel
    {
        private readonly ILogger<ReservationModel> _logger;

        public ReservationModel(ILogger<ReservationModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
