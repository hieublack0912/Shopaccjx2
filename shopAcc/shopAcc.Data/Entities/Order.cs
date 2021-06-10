using shopAcc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public Guid UserId { get; set; }

        public int Status { get; set; }

        public decimal Price { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }

        public AppUser AppUser { get; set; }
    }
}