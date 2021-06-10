using Microsoft.EntityFrameworkCore;
using shopAcc.Data.EF;
using shopAcc.Data.Entities;
using shopAcc.Utilities.Exceptions;
using shopAcc.ViewModels.Catalog.AccountBalances;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Catalog.AccountBalances
{
    public class BalanceService : IBalanceService
    {
        private readonly EShopDbContext _context;

        public BalanceService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<BalanceVm>> GetAllPaging(GetBalancePagingRequest request)
        {
            //1. Select join
            var query = from ab in _context.AccountBalances
                        join us in _context.Users on ab.UserId equals us.Id
                        select new { ab, us };
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.us.UserName.Contains(request.Keyword));
            int totalRow = await query.CountAsync();
            //3. Paging
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize).Select(x => new BalanceVm()
                {
                    Id = x.ab.Id,
                    UserId = x.ab.UserId,
                    UserName = x.us.UserName,
                    Balance = x.ab.Balance
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<BalanceVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<List<BalanceVm>> GetAll()
        {
            var query = from ab in _context.AccountBalances
                        join us in _context.Users on ab.UserId equals us.Id
                        select new { ab, us };
            return await query.Select(x => new BalanceVm()
            {
                Id = x.ab.Id,
                UserName = x.us.UserName,
                UserId = x.ab.UserId,
                Balance = x.ab.Balance
            }).ToListAsync();
        }

        public async Task<bool> UpdateBalance(BalanceUpdateRequest request)
        {
            var user = await _context.AccountBalances.FindAsync(request.Id);
            if (user == null) throw new shopException($"Cannot find a User with id: {request.Id}");
            if (user.Balance + request.BalanceUpdate < 0)
            {
                throw new shopException($"Không thể thực hiện vì số dư tài khoản có ID: {request.Id} thấp hơn số tiền giao dịch");
            }
            user.Balance += request.BalanceUpdate;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<BalanceVm> GetById(int id)
        {
            var query = from c in _context.AccountBalances
                        join us in _context.Users on c.UserId equals us.Id
                        where c.Id == id
                        select new { c, us };
            return await query.Select(x => new BalanceVm()
            {
                Id = x.c.Id,
                UserName = x.us.UserName,
                UserId = x.c.UserId,
                Balance = x.c.Balance
            }).FirstOrDefaultAsync();
        }

        public async Task<bool> ClearBalance(BalanceUpdateRequest request)
        {
            if (request.BalanceUpdate < 0)
            {
                throw new shopException("Không thể thực hiện vì số tiền giao dịch quá thấp");
            }
            var user = await _context.AccountBalances.FindAsync(request.Id);
            if (user == null) throw new shopException($"Cannot find a User with id: {request.Id}");
            if (user.Balance - request.BalanceUpdate < 0)
            {
                throw new shopException($"Không thể thực hiện vì số dư tài khoản có ID: {request.Id} thấp hơn số tiền giao dịch");
            }
            user.Balance -= request.BalanceUpdate;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<BalanceVm> GetByIdUser(Guid id)
        {
            var query = from c in _context.AccountBalances
                        join us in _context.Users on c.UserId equals us.Id
                        where c.UserId == id
                        select new { c, us };
            return await query.Select(x => new BalanceVm()
            {
                Id = x.c.Id,
                UserName = x.us.UserName,
                UserId = x.c.UserId,
                Balance = x.c.Balance
            }).FirstOrDefaultAsync();
        }
    }
}