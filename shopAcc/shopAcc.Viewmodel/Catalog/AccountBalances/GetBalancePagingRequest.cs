using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.AccountBalances
{
    public class GetBalancePagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}