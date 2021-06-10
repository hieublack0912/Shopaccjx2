using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Catalog.Categories;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Models
{
    public class AccountCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<AccountVm> Accounts { get; set; }
    }
}