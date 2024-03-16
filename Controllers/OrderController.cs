using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        private readonly Se1708Context _context;


        public OrderController(Se1708Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> MyOrders()
        {
            // Lấy CustomerId từ Session
            var customerIdString = HttpContext.Session.GetString("CustomerId");

            if (string.IsNullOrEmpty(customerIdString))
            {
                // Nếu không có CustomerId trong Session, chuyển hướng đến trang đăng nhập
                return RedirectToAction("Login", "Accounts");
            }

            int customerId = Convert.ToInt32(customerIdString);

            // Truy vấn các đơn hàng của khách hàng từ cơ sở dữ liệu
            var orders = await _context.Orders
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();

            // Trả về view chứa danh sách các đơn hàng
            return View(orders);
        }

        public async Task<IActionResult> MyOrderDetails(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            // Truy vấn chi tiết đơn hàng từ cơ sở dữ liệu, bao gồm thông tin sản phẩm
            var orderDetails = await _context.OrderDetails
                .Where(od => od.OrderId == orderId)
                .Include(od => od.Product) // Kết hợp với thông tin sản phẩm từ bảng Product
                .ToListAsync();

            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }
    }
}
