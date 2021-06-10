using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int Reincarnation { get; set; }

        public int Visional { get; set; }
        public string UserNameAcc { get; set; }

        public string PasswordAcc { get; set; }

        public string UserCreate { get; set; }
        public bool IsFeatured { get; set; }

        public List<AccountInCategory> AccountInCategories { get; set; }

        public List<Order> Orders { get; set; }

        public List<AccountImage> AccountImages { get; set; }
    }
}