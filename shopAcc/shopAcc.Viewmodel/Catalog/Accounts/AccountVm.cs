using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Catalog.Accounts
{
    public class AccountVm
    {
        public int Id { set; get; }

        public decimal Price { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public int Reincarnation { get; set; }

        public int Visional { get; set; }
        public string UserNameAcc { get; set; }

        public string PasswordAcc { get; set; }

        public string UserCreate { get; set; }
        public bool IsFeatured { get; set; }

        public string ThumbnailImage { get; set; }

        public List<string> Categories { get; set; } = new List<string>();
    }
}