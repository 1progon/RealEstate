using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers;

public class HomepageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}