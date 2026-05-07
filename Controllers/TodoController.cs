using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly AppDbContext _context;

        public TodoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var items=_context.TodoItems.ToList();
            return View(items);
        }


        public IActionResult Add(string title,string description)
        {
            if (!string.IsNullOrEmpty(title))
            {
                var task = new TodoItems
                {
                    Title = title,
                    Description = description,
                    isCompleted = false
                };
                _context.TodoItems.Add(task);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult ToggleDone(int id)
        {
            var item = _context.TodoItems.Find(id);
            if (item != null)
            {
                item.isCompleted = !item.isCompleted;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var item = _context.TodoItems.Find(id);
            if (item != null)
            {
                _context.TodoItems.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}
