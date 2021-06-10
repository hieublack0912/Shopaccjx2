using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface ITransactionApiClient
    {
        Task<PagedResult<TransactionVm>> GetPagings(GetTransactionPagingRequest request);

        Task<bool> CreateTransaction(TransactionCreateRequest request);

        Task<TransactionVm> GetById(int id);
    }
}