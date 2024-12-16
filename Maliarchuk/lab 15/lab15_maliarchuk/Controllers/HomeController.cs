using Microsoft.AspNetCore.Mvc;

namespace lab15_maliarchuk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
