using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult ManageUsers()
    {
        return View();
    }

    public IActionResult ManageProducts()
    {
        return View();
    }
}
