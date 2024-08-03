using identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace identity.Controllers
{
    public class UsersController : Controller
    {
        private UserManager<IdentityUser> _userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.UserName, Email = model.Email };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (IdentityError err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(model);
        }
    }
}