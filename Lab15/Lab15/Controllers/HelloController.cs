using Microsoft.AspNetCore.Mvc;

namespace Lab15.Controllers
{
    public class HelloController : Controller

    {

        public IActionResult Index()

        {

            return Content("Вітаю! Це ваш перший контролер у ASP.NET Core MVC.");

        }

    }
}
