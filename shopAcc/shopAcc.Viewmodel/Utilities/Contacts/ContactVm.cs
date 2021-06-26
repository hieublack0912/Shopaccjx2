using shopAcc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.Utilities.Contacts
{
    public class ContactVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Message { get; set; }

        public int Status { get; set; }
    }
}