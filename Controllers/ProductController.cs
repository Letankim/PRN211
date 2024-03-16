using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly Se1708Context _context;

        public ProductController(Se1708Context context)
        {
            _context = context;
        }
        public IActionResult List(int CatID, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var danhMuc = _context.Categories.Find(CatID);
                var lsTinDangs = _context.Products
                        .AsNoTracking()
                        .Include(p => p.Cat)
                        .Where(x => x.CatId == CatID)
                        .OrderByDescending(x => x.DateCreated);

                List<ProductCategoryViewData> models = lsTinDangs.Select(product => new ProductCategoryViewData
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    CatName = danhMuc != null ? danhMuc.CatName : "Not Found"
                }).ToList();
                PagedList<ProductCategoryViewData> pagedModels = new PagedList<ProductCategoryViewData>(models, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCategory = CatID;
                return View(pagedModels);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Index(int? page)
        {

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsProduct = _context.Products
                .AsNoTracking().Include(p => p.Cat)
                .OrderByDescending(x => x.ProductId);

            var lsBlog = _context.Categories
                .AsNoTracking()
                .OrderByDescending(x => x.CatId)
                .Select(x => x.CatName) 
                .ToList();
            ViewBag.Categories = lsBlog;
            PagedList<Product> models = new PagedList<Product>(lsProduct, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [HttpGet("Product/Category/{catId}")]
        public IActionResult Category(int catId, int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsProduct = _context.Products
                .AsNoTracking().Include(p => p.Cat)
                .Where(p => p.CatId == catId)
                .OrderByDescending(x => x.ProductId);
            ViewBag.catId = catId;
            var lsBlog = _context.Categories.AsNoTracking().OrderByDescending(x => x.CatId).Select(x => x.CatName).ToList();
            ViewBag.Categories = lsBlog;
            PagedList<Product> models = new PagedList<Product>(lsProduct, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View("Index", models);
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);

            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}

