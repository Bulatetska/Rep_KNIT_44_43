using Microsoft.AspNetCore.Mvc;

namespace lab15_maliarchuk.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult ManageUsers()
        {
            var users = new List<dynamic>
            {
                new { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
            };
            return View(users);
        }

        public IActionResult ManageProducts()
        {
            var products = new List<dynamic>
            {
                new { Id = 1, Name = "Laptop", Price = 1000 },
                new { Id = 2, Name = "Phone", Price = 500 }
            };
            return View(products);
        }
    }
}
