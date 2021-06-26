using shopAcc.ViewModels.Catalog.AccountImages;
using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface IAccountApiClient
    {
        Task<PagedResult<AccountVm>> GetPagings(GetManageAccountPagingRequest request);

        Task<List<AccountImageViewModel>> GetListImages(int accountId);

        Task<bool> CreateAccount(AccountCreateRequest request);

        Task<bool> UpdateAccount(AccountUpdateRequest request);

        Task<bool> UpdateView(int Id);

        Task<bool> NoSell(int Id, bool status);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<bool> AddImage(AccountImageCreateRequest request);

        Task<AccountVm> GetById(int id);

        Task<List<AccountVm>> GetFeaturedAccounts(int take);

        Task<List<AccountVm>> GetLatestAccounts(int take);

        Task<bool> DeleteAccount(int id);

        Task<bool> DeleteImage(int id);
    }
}