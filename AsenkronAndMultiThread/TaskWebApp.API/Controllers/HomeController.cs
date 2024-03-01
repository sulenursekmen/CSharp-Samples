using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //Dependency Injection
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //CancellationToken
        [HttpGet]
        public async Task<IActionResult> GetContentAsync(CancellationToken token)
        {
            try
            {
                _logger.LogInformation("Started Request");

                await Task.Delay(5000, token);

                //Thread.Sleep(5000);
                var myTask = new HttpClient().GetStringAsync("https://www.google.com");

                // other transactions

                var data = await myTask;

                _logger.LogInformation("Finished Request");
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Cancelled request" + ex.Message);
                return BadRequest();
            }

        }
    }
}
