using lab15_maliarchuk.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab15_maliarchuk.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1000 },
                new Product { Id = 2, Name = "Phone", Price = 500 }
            };

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, decimal price)
        {
            if (string.IsNullOrEmpty(name) || price <= 0)
            {
                ViewData["Message"] = "Invalid product details!";
                return View();
            }

            // Логіка збереження продукту
            ViewData["Message"] = "Product created successfully!";
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            var product = new { Id = id, Name = "Sample Product", Price = 500 };
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, decimal price)
        {
            if (string.IsNullOrEmpty(name) || price <= 0)
            {
                ViewData["Message"] = "Invalid product details!";
                return View();
            }

            // Логіка оновлення продукту
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var product = new { Id = id, Name = "Sample Product" };
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            // Логіка видалення продукту
            return RedirectToAction("List");
        }
    }
}
