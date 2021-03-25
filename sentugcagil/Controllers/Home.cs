using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sentugcagil.Controllers
{
    public class WebHookDummy
    {
        public string Email { get; set; }
        public string Message { get; set; }

    }

    [Route("")]
    [ApiController]
    public class Home : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public Home(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            return Ok(new { firstname = "Cagil", lastname = "Sentug" });
        }


        [HttpGet("whoami")]
        public async Task<IActionResult> Get(string firstName, string lastName)
        {
            return Ok(new { firstname = firstName, lastname = lastName });
        }

        [HttpPost("alert")]
        public async Task<IActionResult> Post(WebHookDummy hookModel)
        {

            var requestBody = new StringContent(JsonConvert.SerializeObject(hookModel), Encoding.UTF8, "application/json");
            var _httpClient = _clientFactory.CreateClient();
            using var httpResponse = await _httpClient.PostAsync("https://webhook.site/58281ffb-2f8d-402f-bc12-986cf7aa7cf9", requestBody);
            return Ok(httpResponse.StatusCode);
        }
    }
}
