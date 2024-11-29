using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab13._web_app_ASP.NET_Core_MVC.Controllers
{
    public class HelloController : Controller

    {

        public IActionResult Index()

        {

            return Content("Вітаю! Це ваш перший контролер у ASP.NET Core MVC.");

        }

    }
}
