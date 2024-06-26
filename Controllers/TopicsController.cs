using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebHelloWorld.Data;
using WebHelloWorld.Models;

namespace WebHelloWorld.Controllers
{
    [Authorize]
    public class TopicsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TopicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var topics = _context.Topics.ToList();
            return View(topics);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                _context.Topics.Add(topic);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }

        public IActionResult Edit(string id)
        {
            var topic = _context.Topics.Find(id);
            if (topic == null)
            {
                return NotFound();
            }
            return View(topic);
        }

        [HttpPost]
        public IActionResult Edit(Topic topic)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(topic).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }

        public IActionResult Delete(string id)
        {
            var topic = _context.Topics
                .Include(t => t.TopicCourses)
                .Include(t => t.UserTopics)
                .FirstOrDefault(t => t.TopicId == id);
    
            if (topic != null)
            {
                _context.TopicCourses.RemoveRange(topic.TopicCourses);
                _context.UserTopics.RemoveRange(topic.UserTopics);
                _context.Topics.Remove(topic);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
