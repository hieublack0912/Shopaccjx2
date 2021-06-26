using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopAcc.ViewModels.Catalog.AccountImages
{
    public class AccountImageCreateRequest
    {
        public int AccountId { get; set; }
        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}