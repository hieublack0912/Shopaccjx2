using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.Accounts
{
    public class GetManageAccountPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public int? CategoryId { get; set; }

        public int? ValueRange { get; set; }
    }
}