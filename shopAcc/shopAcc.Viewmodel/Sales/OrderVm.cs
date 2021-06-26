using shopAcc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Sales
{
    public class OrderVm
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid UserId { get; set; }

        public int Status { get; set; }

        public decimal Price { get; set; }

        public string UserName { get; set; }
        public int AccountId { get; set; }

        public string AccountBuy { get; set; }

        public List<string> Accounts { get; set; } = new List<string>();
    }
}