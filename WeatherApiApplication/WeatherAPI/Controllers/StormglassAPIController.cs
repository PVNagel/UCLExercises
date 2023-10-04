using Microsoft.AspNetCore.Mvc;
using MyClassLibrary;
using System.Net.Http.Headers;
using WeatherApiApplication.Models;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StormglassAPIController : ControllerBase
    {
        private readonly ILogger<StormglassAPIController> _logger;

        public StormglassAPIController(ILogger<StormglassAPIController> logger)
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