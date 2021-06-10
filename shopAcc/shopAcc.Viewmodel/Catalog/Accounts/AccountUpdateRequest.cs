using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.Accounts
{
    public class AccountUpdateRequest
    {
        public int Id { set; get; }

        [Display(Name = "Giá")]
        public decimal Price { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public int Reincarnation { get; set; }

        public int Visional { get; set; }
        public string UserNameAcc { get; set; }

        public string PasswordAcc { get; set; }

        [Display(Name = "Account đang bán")]
        public bool IsFeatured { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}