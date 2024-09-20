using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TelegramRazor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string> myTest {  get; set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            myTest = ["Line1", "Line2", "Line3", "Line4"];
        }

        public void OnPost()
        {
        }

    }
}
