using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int ID)
        {
            return HtmlEncoder.Default.Encode($"Welcome {name} you {ID} old fucker");
        }
    }
}
