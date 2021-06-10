using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Data.Entities
{
    public class AccountInCategory
    {
        public int AccountId { get; set; }

        public Account Account { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}