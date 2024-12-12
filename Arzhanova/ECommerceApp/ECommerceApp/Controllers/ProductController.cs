using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
public class ProductController : Controller
{
    private static List<string> Products = new List<string> { "Телефон", "Ноутбук", "Планшет" };

    // Усі дії цього контролера захищені авторизацією
    [Authorize]
    public IActionResult List()
    {
        return View(Products);  // Передаємо список продуктів в представлення
    }


    // Редагувати продукти можуть тільки користувачі з роллю Admin
    [Authorize(Roles = "Admin")]
    public IActionResult Edit(int id)
    {
        if (id < 0 || id >= Products.Count)
            return NotFound();

        ViewBag.Product = Products[id];
        ViewBag.Id = id;
        return View();
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public IActionResult Edit(int id, string productName)
    {
        if (id < 0 || id >= Products.Count || string.IsNullOrWhiteSpace(productName))
            return BadRequest();

        Products[id] = productName;
        return RedirectToAction("List");
    }

    // Видаляти продукти можуть тільки користувачі з роллю Admin
    [Authorize(Roles = "Admin")]
    public IActionResult Delete(int id)
    {
        if (id < 0 || id >= Products.Count)
            return NotFound();

        ViewBag.Product = Products[id];
        ViewBag.Id = id;
        return View();
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public IActionResult ConfirmDelete(int id)
    {
        if (id < 0 || id >= Products.Count)
            return BadRequest();

        Products.RemoveAt(id);
        return RedirectToAction("List");
    }
}
