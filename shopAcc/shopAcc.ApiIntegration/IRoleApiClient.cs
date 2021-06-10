using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}