using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(string product, int quantity)
        {
            TempData["Message"] = $"Order placed for {quantity} of {product}.";
            return RedirectToAction("Confirmation");
        }

        public IActionResult Confirmation()
        {
            return View();
        }

    }
}
