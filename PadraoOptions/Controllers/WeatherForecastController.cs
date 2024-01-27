using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace PadraoOptions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherOptions _weatherOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptionsMonitor<WeatherOptions> weatherOptions)
        {
            _logger = logger;
            _weatherOptions = weatherOptions.CurrentValue;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            var fixedValue = _weatherOptions.FixedValue;
            return fixedValue ? "Voltou True" : "Voltou False";
        }

        [HttpGet("weather", Name = "GetWeather")]
        public IEnumerable<WeatherForecast> GetWeather()
        {
            var fixedValue = _weatherOptions.FixedValue;

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = fixedValue ? Random.Shared.Next(-20, -10) : Random.Shared.Next(90, 105),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}
