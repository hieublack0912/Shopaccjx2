using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.AccountBalances
{
    public class BalanceUpdateRequest
    {
        public int Id { get; set; }

        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        public Guid UserId { get; set; }

        [Display(Name = "Số tiền muốn cộng")]
        public decimal BalanceUpdate { get; set; }
    }
}