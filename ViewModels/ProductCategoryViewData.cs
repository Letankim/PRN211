using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class ProductCategoryViewData
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int CatId { get; set; }
        public string CatName { get; set; }
        public List<Category> Categories { get; set; }

    }
}
