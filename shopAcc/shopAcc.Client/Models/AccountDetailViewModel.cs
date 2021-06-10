using shopAcc.ViewModels.Catalog.AccountImages;
using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Models
{
    public class AccountDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public AccountVm Account { get; set; }

        public List<AccountVm> RelatedAccounts { get; set; }

        public List<AccountImageViewModel> AccountImages { get; set; }
    }
}