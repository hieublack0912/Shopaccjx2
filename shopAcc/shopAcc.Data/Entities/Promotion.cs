using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool ApplyForAll { get; set; }

        public int? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

        public string AccountIds { get; set; }

        public string AccountCategoryIds { get; set; }

        public int Status { get; set; }

        public string Name { get; set; }
    }
}