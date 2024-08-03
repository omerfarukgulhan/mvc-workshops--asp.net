using WorkingWithDB.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithDB.Controllers
{
    public class CourseRegistrationController : Controller
    {
        private readonly DataContext _context;

        public CourseRegistrationController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var courseRegistrations = await _context
                                .CourseRegistrations
                                .Include(c => c.Student)
                                .Include(c => c.Course)
                                .ToListAsync();
            return View(courseRegistrations);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Students = new SelectList(await _context.Students.ToListAsync(), "StudentId", "FullName");
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(), "CourseId", "Title");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseRegistration model)
        {
            model.RegistrationDate = DateTime.Now;
            _context.CourseRegistrations.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}