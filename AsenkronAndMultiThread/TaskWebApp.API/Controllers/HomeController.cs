using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetContentAsync()
        {
            // 

            var myTask = new HttpClient().GetStringAsync("https://www.google.com");

            // other transactions

            var data = await myTask;

            return Ok(data);

        }
    }
}
