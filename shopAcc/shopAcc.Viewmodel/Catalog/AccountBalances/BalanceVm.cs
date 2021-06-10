using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.AccountBalances
{
    public class BalanceVm
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public decimal Balance { get; set; }
    }
}