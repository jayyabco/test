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
                Exception exception = new("Test exception");

                var data = new Data
                {
                    ID = 1,
                    StackTrace = exception.StackTrace ?? string.Empty
                };
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while processing GetData.");
                Exception exception = new("Test exception");

                var data = new Data
                {
                    ID = 1,
                    StackTrace = ""
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