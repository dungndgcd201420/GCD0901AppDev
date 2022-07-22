using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
 

  public class TodoesController : Controller
  {
    private ApplicationDbContext _context;
    public TodoesController(ApplicationDbContext context)
    {
      _context = context;
    }
    public IActionResult Index()
    {
      IEnumerable todoes = _context.Todoes.ToList();
      return View(todoes);
    }
  }
}
