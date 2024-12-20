using lab15_maliarchuk.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab15_maliarchuk.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        public IActionResult List()
        {
            return View(users);
        }

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

            int newId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;
            users.Add(new User { Id = newId, Name = name, Email = email });

            return RedirectToAction("List");
        }
    }
}
