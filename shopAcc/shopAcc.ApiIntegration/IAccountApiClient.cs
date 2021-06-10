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

        Task<bool> CreateAccount(AccountCreateRequest request);

        Task<bool> UpdateAccount(AccountUpdateRequest request);

        Task<bool> UpdateView(int Id);

        Task<bool> NoSell(int Id);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<AccountVm> GetById(int id);

        Task<List<AccountVm>> GetFeaturedAccounts(int take);

        Task<List<AccountVm>> GetLatestAccounts(int take);

        Task<bool> DeleteAccount(int id);
    }
}