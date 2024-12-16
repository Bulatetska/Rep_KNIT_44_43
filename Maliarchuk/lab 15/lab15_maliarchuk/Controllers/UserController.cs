using Microsoft.AspNetCore.Mvc;

namespace lab15_maliarchuk.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string email)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                ViewData["Message"] = "Invalid user details!";
                return View();
            }

            ViewData["Message"] = "User created successfully!";
            return RedirectToAction("Details", new { id = 1 }); // Імітація переходу до деталей
        }

        public IActionResult Details(int id)
        {
            var user = new { Id = id, Name = "John Doe", Email = "john.doe@example.com" };
            return View(user);
        }
    }
}
