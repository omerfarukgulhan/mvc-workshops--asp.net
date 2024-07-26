using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            var car = new Car();
            car.Id = 1;
            car.Brand = "tesla";
            car.Model = "model y";
            return View(car);
        }
    }
}
