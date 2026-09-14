using Microsoft.AspNetCore.Mvc;

namespace TestRinriku.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class kakController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "หมูหมีกากๆกังๆ","หมูพีเอ๋อมะแหวว","แหววมะเอ๋อ"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}