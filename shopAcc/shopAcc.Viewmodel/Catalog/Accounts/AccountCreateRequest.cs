using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.Accounts
{
    public class AccountCreateRequest
    {
        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tiêu đề account")]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Display(Name = "Ghi chú")]
        public string Description { get; set; }

        [Display(Name = "Cấp chuyển sinh")]
        public int Reincarnation { get; set; }

        [Display(Name = "Cấp hóa cảnh")]
        public int Visional { get; set; }

        [Display(Name = "Tên đăng nhập tài khoản")]
        public string UserNameAcc { get; set; }

        [Display(Name = "Mật khẩu tài khoản")]
        public string PasswordAcc { get; set; }

        public string UserCreate { get; set; }
        public bool IsFeatured { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}