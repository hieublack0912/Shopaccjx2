using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.System.Users
{
    public class ChangePassWordRequest
    {
        public Guid Id { get; set; }

        public string PassWord { get; set; }

        public string NewPassWord { get; set; }
    }
}