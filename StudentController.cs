using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly YourDbContext _context;

        public StudentController(YourDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        
        public IActionResult CreateMarksheet()
        {
            ViewBag.Students = _context.Students.ToList();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMarksheet(Marksheet marksheet)
        {
            if (ModelState.IsValid)
            {
                _context.Marksheets.Add(marksheet);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Students = _context.Students.ToList();
            return View(marksheet);
        }
    }
}
    }
}
