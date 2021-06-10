using shopAcc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Sales
{
    public class OrderUpdateRequest
    {
        public int Id { get; set; }

        public int Status { get; set; }
    }
}