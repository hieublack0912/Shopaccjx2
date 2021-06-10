using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using shopAcc.ViewModels.Catalog.AccountImages;
using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Common;

namespace shopAcc.Application.Catalog.Accounts
{
    public interface IAccountService
    {
        Task<int> Create(AccountCreateRequest request);

        Task<int> Update(AccountUpdateRequest request);

        Task<int> Delete(int accountId);

        Task<AccountVm> GetById(int accountId);

        Task<bool> UpdatePrice(int accountId, decimal newPrice);

        Task<bool> AddViewcount(int accountId);

        Task<bool> NoSell(int accountId);

        Task<PagedResult<AccountVm>> GetAllPaging(GetManageAccountPagingRequest request);

        Task<int> AddImage(int accountId, AccountImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, AccountImageUpdateRequest request);

        Task<AccountImageViewModel> GetImageById(int imageId);

        Task<List<AccountImageViewModel>> GetListImages(int accountId);

        Task<PagedResult<AccountVm>> GetAllByCategoryId(GetPublicAccountPagingRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<List<AccountVm>> GetFeaturedAccounts(int take);

        Task<List<AccountVm>> GetLatestAccounts(int take);
    }
}