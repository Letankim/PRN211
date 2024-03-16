using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ShowBlogController : Controller
    {
        private readonly Se1708Context _context;
        public ShowBlogController(Se1708Context context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            // Lấy dữ liệu từ bảng Pages
            var pageData = _context.Pages.FirstOrDefault(); // Ví dụ lấy dữ liệu từ bảng Pages

            // Tạo một danh sách BlogViewModel
            var blogViewModelList = new List<BlogViewModel>();

            // Tạo một BlogViewModel từ dữ liệu trang và thêm vào danh sách
            var blogViewModel = new BlogViewModel
            {
                PageId = pageData.PageId,
                PageName = pageData.PageName,
                Contents = pageData.Contents,
                Thumb = pageData.Thumb,
                Title = pageData.Title,
                CreatedAt = pageData.CreatedAt
            };
            blogViewModelList.Add(blogViewModel);

            // Chia danh sách thành các trang sử dụng PagedList
            int pageNumber = (page ?? 1);
            int pageSize = 10; // Số lượng bài viết trên mỗi trang
            var pagedBlogViewModelList = blogViewModelList.ToPagedList(pageNumber, pageSize);

            // Trả về View với danh sách PagedList<BlogViewModel> đã được tạo
            return View(pagedBlogViewModelList);
        }
    }
}
