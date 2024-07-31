using forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace forms.Controllers;

public class HomeController : Controller
{
    public HomeController(ILogger<HomeController> logger)
    {
    }

    public IActionResult Index()
    {
        return View(Repository.Products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
