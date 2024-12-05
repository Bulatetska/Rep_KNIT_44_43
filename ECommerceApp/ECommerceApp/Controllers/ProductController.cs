using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            var products = new List<string> { "Product 1", "Product 2", "Product 3" };
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Симуляція продукту
            var product = $"Product {id}";
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id, string updatedName)
        {
            // Логіка оновлення продукту
            TempData["Message"] = $"Product {id} updated to {updatedName}";
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = $"Product {id}";
            return View(product);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            TempData["Message"] = $"Product {id} deleted.";
            return RedirectToAction("List");
        }

    }
}
