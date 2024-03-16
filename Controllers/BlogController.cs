using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        private readonly Se1708Context _context;

        public BlogController(Se1708Context context)
        {
            _context = context;
        }

        [Route("blogs.html", Name = "Blog")]
        public IActionResult Index()
        {
            var lsTinTucs = _context.TbTinTucs
                .AsNoTracking()
                .OrderByDescending(x => x.PostId)
                .ToList();

            return View(lsTinTucs);
        }

        [Route("/tin-tuc/{Alias}-{id}.html", Name = "TinDetails")]
        public IActionResult Details(string Alias, int id)
        {
            var tinTuc = _context.TbTinTucs.AsNoTracking().SingleOrDefault(x => x.PostId == id && x.Alias == Alias);

            if (tinTuc == null)
            {
                return RedirectToAction("Index");
            }

            return View(tinTuc);
        }
    }
}
