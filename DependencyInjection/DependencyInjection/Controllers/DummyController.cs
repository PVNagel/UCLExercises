using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class DummyController : Controller
    {
        private readonly IDummyClass _dummyClass;

        public DummyController(IDummyClass dummyClass)
        {
            _dummyClass = dummyClass;
        }
        public IActionResult Index()
        {
            string message = _dummyClass.GetMessage();
            return View("Index", message);
        }
    }
}
