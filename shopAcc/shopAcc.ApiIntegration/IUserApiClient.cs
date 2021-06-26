using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<string>> LoginMember(LoginRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<ApiResult<bool>> UpdateMem(Guid id, UserMemUpdateRequest request);

        Task<ApiResult<bool>> ChangePassWord(Guid id, ChangePassWordRequest request);

        Task<ApiResult<UserVm>> GetById(Guid id);

        Task<ApiResult<UserVm>> GetByName(string userName);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}