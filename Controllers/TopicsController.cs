using Microsoft.AspNetCore.Mvc;
using WebHelloWorld.Data;
using WebHelloWorld.Models;

namespace WebHelloWorld.Controllers
{
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

        public IActionResult Delete(string id)
        {
            var topic = _context.Topics.Find(id);
            if (topic != null)
            {  
                _context.Topics.Remove(topic);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}