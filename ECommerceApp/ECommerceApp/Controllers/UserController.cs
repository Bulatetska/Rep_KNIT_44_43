using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string email)
        {
            TempData["Message"] = $"User {name} created with email {email}.";
            return RedirectToAction("Details", new { name });
        }

        public IActionResult Details(string name)
        {
            return View("Details", name);
        }

    }
}
