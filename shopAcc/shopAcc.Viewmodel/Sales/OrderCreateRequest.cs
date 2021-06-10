using shopAcc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Sales
{
    public class OrderCreateRequest
    {
        public Guid UserId { get; set; }

        public decimal Price { get; set; }

        public int AccountId { get; set; }
    }
}