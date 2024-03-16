﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Category
    {
        public int CatId { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        public string CatName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? Levels { get; set; }
        public int? Ordering { get; set; }
        public bool Published { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string Cover { get; set; }
        public string SchemaMarkup { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
