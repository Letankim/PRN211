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
        [Route("blogs.html", Name="Blog")]
        public IActionResult Index(int? page)
        {

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsTinTucs = _context.TbTinTucs
                .AsNoTracking()
                .OrderByDescending(x => x.PostId);
            PagedList<TbTinTuc> models = new PagedList<TbTinTuc>(lsTinTucs, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [Route("/tin-tuc/{Alias}-{id}.html", Name ="TinDetails")]
        public IActionResult Details(int id)
        {
            var tinTuc = _context.TbTinTucs.AsNoTracking().SingleOrDefault(x=>x.PostId== id);

            if (tinTuc == null)
            {
                return RedirectToAction("Index");
            }
            return View(tinTuc);
        }
    }
}
