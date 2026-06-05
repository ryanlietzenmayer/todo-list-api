using Microsoft.AspNetCore.Mvc;


// GET
// GET ALL
// POST
// PUT
// DELETE
namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ToDoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Handles the HTTP POST request to create a new to-do item
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create(ToDo.Models.ToDo todo)
        {
            if (ModelState.IsValid)
            {
                _context.ToDos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo);
        }
    }
}
