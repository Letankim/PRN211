using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Extension;
using WebApplication1.Helper;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly Se1708Context _context;
        public CheckoutController(Se1708Context context)
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
        [Route("checkout.html", Name ="Checkout")]
        public IActionResult Index(string returnUrl= null)
        {
            var cart = HttpContext.Session.Get<List<CartItemcs>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

            }
            ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "LocationId", "Name");
                ViewBag.GioHang = cart;
            return View(model);
                }

        [HttpPost]
        [Route("checkout.html", Name ="Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            var cart = HttpContext.Session.Get<List<CartItemcs>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if(taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId ==Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

                khachhang.LocationId = muaHang.TinhThanh;
                khachhang.District = muaHang.QuanHuyen;
                khachhang.Ward = muaHang.PhuongXa;
                khachhang.Address = muaHang.Address;
                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                
                    Order donhang = new Order();
                    donhang.CustomerId = model.CustomerId;
                    donhang.Address = model.Address;
                    donhang.District = model.QuanHuyen;
                    donhang.Ward = model.PhuongXa;
                    
                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;
                    donhang.Deleted = false;
                    donhang.Paid= false;
                    donhang.Note = Ultilities.StripHTML(model.Note);
                    donhang.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Update(donhang);
                    _context.SaveChanges();

                    foreach(var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = donhang.OrderID;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Quantity = item.amount;
                        orderDetail.Total = donhang.TotalMoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);

                    }
                    _context.SaveChanges();

                    HttpContext.Session.Remove("GioHang");
                    //NotiFYSERVICE.SUCCESS("dat hang thanh cong);
                    return RedirectToAction("Success");




                }
            }catch(Exception ex) 
            {
                ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "LocationId", "Name");
                ViewBag.GioHang = cart;
                return View(model);
            }
            ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "LocationId", "Name");
            ViewBag.GioHang = cart;
            _context.SaveChanges();

            return View(model);
        }

        [Route("dat-hang-thanh-cong.html", Name ="Success")]
        public IActionResult Success() 
        
        {
         try
            {
                var taikhoanID = HttpContext.Session.GetString("CustoemrId");
                if(string.IsNullOrEmpty(taikhoanID) )
                {
                    return RedirectToAction("Login", "Accounts", new
                    {
                        returnUrl = "/dat-hang-thanh-cong.html"
                    });
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                var donhang = _context.Orders.Where(x => x.CustomerId == Convert.ToInt32(taikhoanID)).OrderByDescending(x => x.OrderDate).FirstOrDefault();
                
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.DonHangID = donhang.OrderID;
                successVM.Phone = khachhang.Phone;
                successVM.Address = khachhang.Address;
                successVM.PhuongXa = donhang.Ward.Value;
                successVM.TinhThanh =donhang.District.Value;
                return View(successVM);
            }
            catch
            {
                return View();
            }
        
        
        }
      
    }
}
