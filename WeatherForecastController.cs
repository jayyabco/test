using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("a/GetData")]
        public IActionResult GetData()
        {
            try
            {
                int zero = 0;
                int result = 100 / zero;
                return Ok(result);
            }
            catch (Exception ex)
            {
                var data = new Data
                {
                    ID = 1,
                    StackTrace = ex.StackTrace
                };

                _logger.LogError(ex, "Error occurred while processing GetData.");

                return StatusCode(500, data);
            }
        }

        public class Data
        {
            public int ID { get; set; }
            public string StackTrace { get; set; } = string.Empty;
        }
    }
}