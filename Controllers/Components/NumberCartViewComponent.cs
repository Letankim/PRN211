using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Extension;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers.Component
{
    public class NumberCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItemcs>>("GioHang");
            
            if (cart == null)
            {
                cart = new List<CartItemcs>(); // Create an empty list if cart is null
            }

            return View(cart);
        }
    }
}
