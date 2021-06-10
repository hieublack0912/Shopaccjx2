using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.System.Transactions
{
    public interface ITransactionService
    {
        Task<int> Create(TransactionCreateRequest request);

        Task<PagedResult<TransactionVm>> GetAllPaging(GetTransactionPagingRequest request);

        Task<TransactionVm> GetById(int transId);
    }
}