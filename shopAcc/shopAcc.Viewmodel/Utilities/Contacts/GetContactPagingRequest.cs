using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Utilities.Contacts
{
    public class GetContactPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}