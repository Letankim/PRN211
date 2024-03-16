using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PageController : Controller
    {
        private readonly Se1708Context _context;

        public PageController(Se1708Context context)
        {
            _context = context;
        }

        [Route("/page/{Alias}", Name = "PageDetails")]

        public IActionResult Details(string Alias)

        {
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(page);
        }
    }
}
