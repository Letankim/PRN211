using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        public string ProductName { get; set; }

        public string ShortDesc { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn một danh mục")]
        public int? CatId { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Giá chỉ được phép nhập số")]
        public int? Price {   get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "Chỉ được phép nhập số")]
        public int? Discount { get; set; }
        public string Title { get; set; }
        public string Thumb { get; set; }
        public string Video { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool BestSellers { get; set; }
        public bool HomeFlag { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public int? UnitslnStock { get; set; }
        public virtual Category Cat { get; set; }
    }
}
