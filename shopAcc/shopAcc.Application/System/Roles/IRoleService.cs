using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();

        Task<ApiResult<bool>> Create(CreateRoleRequest request);
    }
}