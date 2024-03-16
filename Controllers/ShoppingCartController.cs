    using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Extension;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly Se1708Context _context;
        public ShoppingCartController(Se1708Context context)
        {
            _context = context;
        }
        public List<CartItemcs> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItemcs>>("GioHang");
                if (gh == default(List<CartItemcs>))
                {
                    gh = new List<CartItemcs>();    
                }
                return gh;
            }
        }

        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            try
            {
                List<CartItemcs> giohang = GioHang;

                CartItemcs item = giohang.SingleOrDefault(p => p.product.ProductId == productID);

                if (item != null)
                {
                    item.amount += amount ?? 1; // Tăng số lượng nếu sản phẩm đã có trong giỏ hàng
                }
                else
                {
                    Product hh = _context.Products.SingleOrDefault(p => p.ProductId == productID);
                    item = new CartItemcs
                    {
                        amount = amount ?? 1,
                        product = hh
                    };
                    giohang.Add(item); // Thêm mới sản phẩm vào giỏ hàng
                }

                HttpContext.Session.Set<List<CartItemcs>>("GioHang", giohang); 
                return Json(new { success = true, message = "Product added to cart successfully!" });
            }
            catch
            {
                return Json(new { success = false, message = "Product added to cart Fail!" });
            }
         
        }


        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            var cart = HttpContext.Session.Get<List<CartItemcs>>("GioHang");
            try
            {
                if (cart != null)
                {
                    CartItemcs item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                    if (item != null && amount.HasValue) {
                        item.amount = amount.Value;
                    }
                    HttpContext.Session.Set<List<CartItemcs>>("GioHang", cart);
                }
                return Json(new { success = true });
            }catch { return Json(new { success = false });}
        }

     
        [Route("api/cart/remove")]
        public ActionResult Remove(int productID) {
            
            List<CartItemcs> giohang = GioHang;
            try
            {
                CartItemcs item = giohang.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null)
                {
                    giohang.Remove(item);
                }
                HttpContext.Session.Set<List<CartItemcs>>("GioHang", giohang);
                return Json(new { success = true });

            }
            catch
            {
                return Json(new { success = false });

            }

        

        }
        [Route("cart.html", Name ="Cart")]
        public IActionResult Index()
        {
       
            return View(GioHang);     
        }
    }
}
