using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
	[HttpPost]
	public IActionResult PlaceOrder(string product, int quantity)
	{
		ViewBag.Message = $"Замовлення на {quantity} одиниць продукту '{product}' розміщене!";
		return View();
	}
}
