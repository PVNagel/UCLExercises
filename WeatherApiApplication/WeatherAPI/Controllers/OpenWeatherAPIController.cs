using Microsoft.AspNetCore.Mvc;
using WeatherApiApplication.Models;
using MyClassLibrary;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenWeatherAPIController : ControllerBase
    {
        private readonly ILogger<OpenWeatherAPIController> _logger;

        public OpenWeatherAPIController(ILogger<OpenWeatherAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<OpenWeatherRoot> Get()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/forecast?lat=55.4038&lon=10.4024&appid=166123e62d590ebc5c2930b133a74c7b&units=metric");
            var result = await httpClient.GetFromJsonAsync<OpenWeatherRoot>(httpClient.BaseAddress);
            return result;
        }
    }
}