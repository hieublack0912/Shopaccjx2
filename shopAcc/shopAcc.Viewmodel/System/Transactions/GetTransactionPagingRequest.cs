using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.System.Transactions
{
    public class GetTransactionPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string UserName { get; set; }
    }
}