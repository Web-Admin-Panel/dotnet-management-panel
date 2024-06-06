using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Data;
using WebHelloWorld.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebHelloWorld.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                // Include related data for Courses - TopicCourses and their Topics
                Courses = await _context.Courses
                    .Include(c => c.TopicCourses)
                    .ThenInclude(tc => tc.Topic)
                    .ToListAsync(),

                // Topics and Users don't need Includes here since they have no further navigation in this context
                Topics = await _context.Topics.ToListAsync()
                // Users = await _context.Users.ToListAsync()
            };

            return View(viewModel);
        }
    }
}