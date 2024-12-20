using lab15_maliarchuk.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab15_maliarchuk.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName) || quantity <= 0)
            {
                ViewData["Message"] = "Invalid order details!";
                return View();
            }

            ViewData["Message"] = "Order placed successfully!";
            return View("OrderConfirmation"); 
        }

        public IActionResult List()
        {
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Продукт 1", Quantity = 2, CustomerName = "Ім'я клієнта", CustomerEmail = "email@example.com" },
                new Order { Id = 2, ProductName = "Продукт 2", Quantity = 1, CustomerName = "Ім'я клієнта 2", CustomerEmail = "email2@example.com" }
            };

            return View(orders);
        }
    }
}
