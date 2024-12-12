using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    public IActionResult Create()
    {
        return View("~/Views/Shared/Create.cshtml");
    }

    [HttpPost]
    public IActionResult Create(string name, string email)
    {
        ViewBag.Message = $"Користувач {name} ({email}) створений успішно!";
        return View("Details");
    }

    public IActionResult Details(string name, string email)
    {
        ViewBag.Name = name;
        ViewBag.Email = email;
        return View("~/Views/Shared/Details.cshtml");
    }
}
