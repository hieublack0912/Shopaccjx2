using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopAcc.ViewModels.Catalog.Accounts
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}