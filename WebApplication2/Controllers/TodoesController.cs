using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
 

  public class TodoesController : Controller
  {
    private ApplicationDbContext _context;
    public TodoesController(ApplicationDbContext context)
    {
      _context = context;
    }
    [HttpGet]
    public IActionResult Index()
    {
      IEnumerable todoes = _context.Todoes.ToList();
      return View(todoes);
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }
    public IActionResult Create(Todo todo)
    {
      var newTodo = new Todo
      {
        Description = todo.Description
      };

      _context.Add(newTodo);
      _context.SaveChanges();
      return RedirectToAction("Index");
      
    }
  }
}
