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

            // Логіка для збереження замовлення
            ViewData["Message"] = "Order placed successfully!";
            return View("OrderConfirmation"); // Відображення підтвердження
        }
    }
}
