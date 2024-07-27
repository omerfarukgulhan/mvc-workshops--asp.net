using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List", "Car");
            }

            var cars = Repository.GetById(id);

            return View(cars);
        }

        public IActionResult List()
        {
            return View("CarList", Repository.Cars);
        }
    }
}
