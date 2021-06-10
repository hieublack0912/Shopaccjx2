using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Models
{
    public class CheckoutView
    {
        public int AccountId { set; get; }
        public Guid UserId { set; get; }

        public string Title { get; set; }

        public decimal Price { set; get; }

        public decimal Balance { get; set; }
    }
}