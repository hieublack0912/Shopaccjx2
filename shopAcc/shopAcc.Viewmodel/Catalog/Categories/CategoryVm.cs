using shopAcc.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace shopAcc.ViewModels.Catalog.Categories
{
    public class CategoryVm
    {
        public int Id { get; set; }

        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }

        [Display(Name = "Mô tả danh mục")]
        public string SeoDescription { get; set; }

        [Display(Name = "Tiêu dề danh mục")]
        public string SeoTitle { get; set; }

        [Display(Name = "Bí danh")]
        public string SeoAlias { get; set; }

        [Display(Name = "Thứ tự ưu tiên")]
        public int SortOrder { get; set; }

        [Display(Name = "Có hiển thị ở trang chủ")]
        public bool IsShowOnHome { get; set; }

        [Display(Name = "Trạng thái")]
        public Status Status { get; set; }

        public int? ParentId { get; set; }
    }
}