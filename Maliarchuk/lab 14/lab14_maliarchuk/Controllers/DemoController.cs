using Microsoft.AspNetCore.Mvc;

namespace lab14_maliarchuk.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Ласкаво просимо на лабораторну роботу з Razor!";

            var countries = new List<string> { "Україна", "Польща", "Німеччина", "Франція" };
            return View(countries);
        }
    }
}
