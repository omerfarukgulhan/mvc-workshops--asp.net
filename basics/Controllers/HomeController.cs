using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(Repository.Cars);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
