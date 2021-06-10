using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<AccountVm> FeaturedProducts { get; set; }

        public List<AccountVm> LatestProducts { get; set; }
    }
}