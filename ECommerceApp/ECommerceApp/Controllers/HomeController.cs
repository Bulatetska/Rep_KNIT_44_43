using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerceApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
