using Microsoft.AspNetCore.Mvc;
using WeatherApiApplication.Models;

namespace WeatherAPI.Controllers
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

        [HttpGet]
        public async Task<Root> Get()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=166123e62d590ebc5c2930b133a74c7b&units=metric");
            var result = await httpClient.GetFromJsonAsync<Root>(httpClient.BaseAddress);
            return result;
        }
    }
}