using Microsoft.AspNetCore.Mvc;
using MyClassLibrary;
using System.Net.Http.Headers;

namespace WeatherAPI.Controllers.v2
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("2.0")]
    public class WeatherAPIController : ControllerBase
    {
        private readonly ILogger<WeatherAPIController> _logger;

        public WeatherAPIController(ILogger<WeatherAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<StormglassRoot> Get()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.stormglass.io/v2/weather/point?lat=55.39&lng=10.38&params=swellHeight,swellPeriod");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("0383bdf2-628a-11ee-a654-0242ac130002-0383be4c-628a-11ee-a654-0242ac130002");
            var result = await httpClient.GetFromJsonAsync<StormglassRoot>(httpClient.BaseAddress);
            return result;
        }
    }
}