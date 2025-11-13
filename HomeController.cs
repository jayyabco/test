using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("S/Data")]
        public IActionResult GetData()
        {
            try
            {
                throw new InvalidOperationException("Simulated exception for testing.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while processing GetData.");

                var data = new Data
                {
                    ID = 1,
                    StackTrace = ex.StackTrace ?? string.Empty
                };
                return Ok(data);
            }
        }

        public class Data
        {
            public int ID { get; set; }

            public string StackTrace { get; set; } = string.Empty;
        }
    }
}