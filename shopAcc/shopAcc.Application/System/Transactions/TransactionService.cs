using Microsoft.EntityFrameworkCore;
using shopAcc.Data.EF;
using shopAcc.Data.Entities;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.System.Transactions
{
    public class TransactionService : ITransactionService
    {
        private readonly EShopDbContext _context;

        public TransactionService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(TransactionCreateRequest request)
        {
            var transaction = new Transaction()
            {
                TransactionDate = DateTime.Now,
                ExternalTransactionId = request.ExternalTransactionId,
                Amount = request.Amount,
                Fee = 0,
                Result = request.Result,
                Message = request.Message,
                Status = request.Status,
                Provider = "shopaccJx2",
                UserId = request.UserId,
            };
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return transaction.Id;
        }

        public async Task<PagedResult<TransactionVm>> GetAllPaging(GetTransactionPagingRequest request)
        {
            //1. Select join
            var query = from t in _context.Transactions
                        join us in _context.Users on t.UserId equals us.Id
                        where t.Status == 0
                        select new { t, us };

            //2. filter
            query = query.Where(x => x.us.UserName.Contains(request.UserName));
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.t.Message.Contains(request.Keyword));

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
               .Take(request.PageSize)
               .Select(x => new TransactionVm()
               {
                   Id = x.t.Id,
                   TransactionDate = x.t.TransactionDate,
                   Amount = x.t.Amount,
                   Result = x.t.Result,
                   Message = x.t.Message,
                   Status = x.t.Status,
                   Provider = x.t.Provider,
                   UserId = x.us.Id,
                   UserName = x.us.UserName,
               }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<TransactionVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<TransactionVm> GetById(int transId)
        {
            var transaction = await _context.Transactions.FindAsync(transId);

            var transactionViewModel = new TransactionVm()
            {
                Id = transaction.Id,
                TransactionDate = transaction.TransactionDate,
                Amount = transaction.Amount,
                Result = transaction.Result,
                Message = transaction.Message,
                Status = transaction.Status,
                Provider = transaction.Provider,
                UserId = transaction.UserId
            };
            return transactionViewModel;
        }
    }
}