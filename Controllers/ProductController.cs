using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
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
            var pageSize = 1;
            var lsProduct = _context.Products
                .AsNoTracking().Include(p => p.Cat)
                .Where(p => (p.Active && p.Cat.Published))
                .OrderByDescending(x => x.ProductId);
            var lsCat = _context.Categories
                .AsNoTracking()
                .OrderByDescending(x => x.CatId)
                .ToList();
            ViewBag.Categories = lsCat;
            PagedList<Product> models = new PagedList<Product>(lsProduct, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            ViewBag.numberOfProduct = lsProduct.Count();
            return View(models);
        }


        [HttpGet("Product/Category/{catId}")]
        public IActionResult Category(int catId, int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsProduct = _context.Products
                .AsNoTracking().Include(p => p.Cat)
                .Where(p => (p.CatId == catId && p.Cat.Published))
                .OrderByDescending(x => x.ProductId);
            ViewBag.catId = catId;
            var lsBlog = _context.Categories
            .AsNoTracking()
            .OrderByDescending(x => x.CatId)
            .ToList();
            ViewBag.Categories = lsBlog;
            PagedList<Product> models = new PagedList<Product>(lsProduct, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            ViewBag.numberOfProduct = models.Count();
            return View("Index", models);
        }

        public IActionResult Search(string key)
        {
            var lsProduct = _context.Products
            .AsNoTracking()
            .Include(p => p.Cat)
            .Where(p => p.Active && p.Cat.Published);
            if (!String.IsNullOrEmpty(key))
            {
                lsProduct = lsProduct.Where(p => p.ProductName.Contains(key));
            }
            lsProduct = lsProduct.OrderByDescending(x => x.ProductId);
            var lsBlog = _context.Categories.
                    AsNoTracking()
                    .OrderByDescending(x => x.CatId)
                    .ToList();
            ViewBag.SearchString = key;
            ViewBag.Categories = lsBlog;
            ViewBag.numberOfProduct = lsProduct.Count();
            return View(lsProduct);
        }

        public IActionResult SortByPrice(int sortOrder)
        {
            var lsProduct = _context.Products
                .AsNoTracking()
                .Include(p => p.Cat)
                .Where(p => p.Active && p.Cat.Published);
            switch (sortOrder)
            {
                case 0:
                    lsProduct = lsProduct.OrderByDescending(p => p.Price);
                    break;
                case 1:
                    lsProduct = lsProduct.OrderBy(p => p.Price);
                    break;
            }
            if (sortOrder != 0 && sortOrder != 1)
            {
                lsProduct = lsProduct.OrderByDescending(x => x.ProductId);
            }
            var lsBlog = _context.Categories
                .AsNoTracking()
                .OrderByDescending(x => x.CatId)
                .ToList();
            ViewBag.Sort = sortOrder;
            ViewBag.Categories = lsBlog;
            ViewBag.numberOfProduct = lsProduct.Count();
            return View(lsProduct.ToList());
        }

        public IActionResult FilterProduct(int[] categories, float minamount, float maxamount)
        {
            List<int?> categoryList = categories.Cast<int?>().ToList();
            var lsProduct = _context.Products
                .AsNoTracking()
                .Include(p => p.Cat)
                .Where(p => p.Active && p.Cat.Published);
            if (categories != null && categories.Length > 0)
            {
                lsProduct = lsProduct.Where(p => categoryList.Contains(p.CatId));
            }

            if (minamount != null && minamount >= 0)
            {
                lsProduct = lsProduct.Where(p => p.Price >= minamount);
            }

            if (maxamount != 0 && maxamount >= minamount)
            {
                lsProduct = lsProduct.Where(p => p.Price <= maxamount);
            }
            lsProduct.OrderBy(p => p.ProductId)
            .ToList();
            var lsBlog = _context.Categories
                .AsNoTracking()
                .OrderByDescending(x => x.CatId)
                .ToList();
            ViewBag.minamount = minamount;
            ViewBag.maxamount = maxamount;
            ViewBag.categoryFilter = categories;
            ViewBag.Categories = lsBlog;
            ViewBag.numberOfProduct = lsProduct.Count();
            return View("Search", lsProduct);

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

