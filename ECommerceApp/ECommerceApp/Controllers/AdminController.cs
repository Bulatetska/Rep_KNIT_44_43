using ECommerceApp.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    [CustomActionFilter]
    public class AdminController : Controller
    {
        public IActionResult IndexAdmin()
        {
            return View();
        }
        public IActionResult ManageUsers()
        {
            var users = new List<string> { "User1", "User2", "User3" }; // Тимчасовий список
            return View(users);
        }

        public IActionResult ManageProducts()
        {
            var products = new List<string> { "Product1", "Product2", "Product3" }; // Тимчасовий список
            return View(products);
        }

    }
}
