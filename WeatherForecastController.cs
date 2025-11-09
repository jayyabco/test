using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

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
                throw new InvalidOperationException("Simulated exception for testing.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while processing GetData.");
                Exception exception = new("Test exception");

                var data = new Data
                {
                    ID = 1,
                    StackTrace = ex.StackTrace ?? string.Empty
                };
                return Ok(data);
            }
        }

        /*public class Data
        {
            public int ID { get; set; }

            [JsonConverter(typeof(EmptyStringJsonConverter))]
            public string StackTrace { get; set; } = string.Empty;
        }  */

        public class Data
        {
            public int ID { get; set; }

            [JsonIgnore]
            public string StackTrace { get; set; } = string.Empty;

            [JsonPropertyName("stackTrace")]
            public string StackTracePublic => string.Empty;
        }
    }
}