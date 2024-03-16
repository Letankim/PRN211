using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Se1708Context _context;

     
        public HomeController(Se1708Context context)
        {
            _context = context;

        }
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsBlog = _context.Categories
                .AsNoTracking().
                OrderByDescending(x => x.CatId).ToList();
            ViewBag.Categories = lsBlog;

            var lsTintuc =_context.TbTinTucs.
                AsNoTracking().
                OrderByDescending(x=> x.PostId).ToList();
            ViewBag.TbTinTucs = lsTintuc;

            var lsProduct = _context.Products
                .AsNoTracking()
                .OrderByDescending(x => x.ProductId)
                .Include(p => p.Cat); // Thực hiện join vào bảng Category
                 PagedList<Product> models = new PagedList<Product>(lsProduct, pageNumber, pageSize);



            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        public IActionResult List(int CatID, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var danhMuc = _context.Categories.Find(CatID);

                // Thực hiện join vào bảng Category và lọc dữ liệu theo CatId
                var lsTinDangs = _context.Products
                    .AsNoTracking()
                     .Include(p => p.Cat)
                    .Where(x => x.CatId == CatID)
                    .OrderByDescending(x => x.DateCreated)
                  
                    ; 

                PagedList<Product> models = new PagedList<Product>(lsTinDangs, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCategory = danhMuc.CatName; // Trả về tên danh mục
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
       

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
