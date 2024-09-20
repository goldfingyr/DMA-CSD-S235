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

        /// <summary>
        /// OnGet is called when the browser issues a GET /
        /// </summary>
        public void OnGet()
        {
            myTest = ["Line1", "Line2", "Line3", "Line4"];
        }

        /// <summary>
        /// OnPost is called when the browser issues a POST /
        /// </summary>
        public void OnPost()
        {
        }

    }
}
