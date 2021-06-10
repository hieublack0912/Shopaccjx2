using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ViewModels.System.Roles
{
    public class CreateRoleRequest
    {
        [Display(Name = "Tên quyền")]
        public string Name { get; set; }

        [Display(Name = "Tên chuẩn hóa")]
        public string NormalizedName { get; set; }

        [Display(Name = "Chú thích")]
        public string Description { get; set; }
    }
}