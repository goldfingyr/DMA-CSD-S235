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

        private void Send2Telegram( string text)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.telegram.org/bot{{AccessToken}}/sendMessage");
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("chat_id", "{{ChatID}}"));
            collection.Add(new("text", text));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = client.Send(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

        }

        /// <summary>
        /// OnPost is called when the browser issues a POST /
        /// </summary>
        public void OnPost(string text2send)
        {
            Send2Telegram(text2send);
        }

    }
}
