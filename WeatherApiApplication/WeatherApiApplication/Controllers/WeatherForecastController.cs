using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WeatherApiApplication.Models;

namespace WeatherApiApplication.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7111/OpenWeatherAPI");
            var result = await httpClient.GetFromJsonAsync<OpenWeatherRoot>(httpClient.BaseAddress);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}