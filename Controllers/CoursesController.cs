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

        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        public IActionResult Delete(int id)
        {
            var course = _context.Courses
                .Include(c => c.UserCourses)
                .Include(c => c.TopicCourses)
                .FirstOrDefault(c => c.CourseId == id);
            
            if (course != null)
            {
                _context.UserCourses.RemoveRange(course.UserCourses);
                _context.TopicCourses.RemoveRange(course.TopicCourses);
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}