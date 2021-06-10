using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Data.Entities
{
    public class AccountBalance
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public decimal Balance { get; set; }

        public AppUser AppUser { get; set; }
    }
}