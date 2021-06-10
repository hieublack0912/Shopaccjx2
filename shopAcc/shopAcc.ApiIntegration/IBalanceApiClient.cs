using shopAcc.ViewModels.Catalog.AccountBalances;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface IBalanceApiClient
    {
        Task<PagedResult<BalanceVm>> GetPagings(GetBalancePagingRequest request);

        Task<bool> UpdateBalance(BalanceUpdateRequest request);

        Task<bool> ClearBalance(BalanceUpdateRequest request);

        Task<List<BalanceVm>> GetAll();

        Task<BalanceVm> GetById(int id);

        Task<BalanceVm> GetByIdUser(Guid id);
    }
}