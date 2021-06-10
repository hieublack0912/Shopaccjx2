using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.Accounts
{
    public class GetPublicAccountPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}