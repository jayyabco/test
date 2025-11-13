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

        [HttpGet("a/APILogging")]
        public async Task<IActionResult> APILogging()
        {
            CalcRepo calcRepo = new CalcRepo();
            var result = await calcRepo.PostSync(5, 10);
            return Ok(result);
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