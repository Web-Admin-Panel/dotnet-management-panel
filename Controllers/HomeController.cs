using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Data; // Use the correct namespace for your DbContext
using WebHelloWorld.ViewModels; // This is where our ViewModel will reside

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
            Courses = await _context.Courses.ToListAsync(),
            Topics = await _context.Topics.ToListAsync(),
            Users = await _context.Users.ToListAsync()
        };

        return View(viewModel);
    }
}