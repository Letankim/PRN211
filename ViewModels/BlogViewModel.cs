using PagedList.Core;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class BlogViewModel
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string CreatedAt { get; set; }


    }
}
