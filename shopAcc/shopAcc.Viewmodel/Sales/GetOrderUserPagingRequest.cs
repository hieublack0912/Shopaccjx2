using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Sales
{
    public class GetOrderUserPagingRequest : PagingRequestBase
    {
        public string UserName { get; set; }
    }
}