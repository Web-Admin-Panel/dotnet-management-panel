using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Data; // Adjust to match your actual DbContext namespace
using WebHelloWorld.ViewModels; // Adjust to match your actual ViewModel namespace
using System.Threading.Tasks;

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
            Topics = await _context.Topics.ToListAsync(),
            Users = await _context.Users.ToListAsync()
        };

        return View(viewModel);
    }
}