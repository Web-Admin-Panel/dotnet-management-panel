using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Data;
using WebHelloWorld.Models;

namespace WebHelloWorld.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;

        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.ToListAsync());
        }
    }
}
