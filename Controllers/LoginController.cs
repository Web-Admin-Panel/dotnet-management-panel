using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Data;
using WebHelloWorld.ViewModels;

namespace WebHelloWorld.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == model.Username);
                if (user != null)
                {
                    {
                        
                    }
                    var admin = _context.Admins.FirstOrDefault(a => a.AdminUserId == user.UserId);
                    if (admin != null && admin.AdminPassword == model.Password)
                    {
                        // Successful login logic here
                        // You could set a session or a cookie to keep the user logged in
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Invalid username or password");
            }
            return View(model);
        }
    }
}