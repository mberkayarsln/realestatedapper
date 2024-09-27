using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}