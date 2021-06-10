using shopAcc.Data.Entities;
using shopAcc.ViewModels.Catalog.AccountBalances;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Catalog.AccountBalances
{
    public interface IBalanceService
    {
        Task<bool> UpdateBalance(BalanceUpdateRequest request);

        Task<bool> ClearBalance(BalanceUpdateRequest request);

        Task<PagedResult<BalanceVm>> GetAllPaging(GetBalancePagingRequest request);

        Task<List<BalanceVm>> GetAll();

        Task<BalanceVm> GetById(int id);

        Task<BalanceVm> GetByIdUser(Guid id);
    }
}