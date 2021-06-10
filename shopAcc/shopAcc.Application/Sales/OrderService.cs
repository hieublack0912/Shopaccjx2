using Microsoft.EntityFrameworkCore;
using shopAcc.Data.EF;
using shopAcc.Data.Entities;
using shopAcc.Data.Enums;
using shopAcc.Utilities.Exceptions;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Sales
{
    public class OrderService : IOrderService
    {
        private readonly EShopDbContext _context;

        public OrderService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(OrderCreateRequest request)
        {
            var order = new Order()
            {
                UserId = request.UserId,
                Status = 0,
                OrderDate = DateTime.Now,
                Price = request.Price,
                AccountId = request.AccountId
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<PagedResult<OrderVm>> GetAllPaging(GetOrderPagingRequest request)
        {
            var query = from o in _context.Orders
                        join a in _context.Accounts on o.AccountId equals a.Id into ao
                        from a in ao.DefaultIfEmpty()
                        join au in _context.Users on o.UserId equals au.Id into auo
                        from au in auo.DefaultIfEmpty()
                        select new { o, a, au };
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.au.UserName.Contains(request.Keyword));

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new OrderVm()
                {
                    Id = x.o.Id,
                    AccountBuy = x.a.Title,
                    UserName = x.au.UserName,
                    Price = x.a.Price,
                    OrderDate = x.o.OrderDate,
                    Status = x.o.Status,
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<OrderVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<OrderVm> GetById(int orderId)
        {
            var query = from o in _context.Orders
                        join a in _context.Accounts on o.AccountId equals a.Id
                        join au in _context.Users on o.UserId equals au.Id
                        where o.Id == orderId
                        select new { o, a, au };

            return await query.Select(x => new OrderVm()
            {
                Id = x.o.Id,
                AccountBuy = x.a.Title,
                UserName = x.au.UserName,
                Price = x.a.Price,
                OrderDate = x.o.OrderDate,
                Status = x.o.Status,
            }).FirstOrDefaultAsync();
        }

        public async Task<PagedResult<OrderVm>> GetAllByUser(GetOrderUserPagingRequest request)
        {
            var query = from o in _context.Orders
                        join a in _context.Accounts on o.AccountId equals a.Id into ao
                        from a in ao.DefaultIfEmpty()
                        join au in _context.Users on o.UserId equals au.Id into auo
                        from au in auo.DefaultIfEmpty()
                        select new { o, a, au };
            //2. filter
            query = query.Where(x => x.au.UserName.Contains(request.UserName));
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new OrderVm()
                {
                    Id = x.o.Id,
                    AccountBuy = x.a.Title,
                    UserName = x.au.UserName,
                    Price = x.a.Price,
                    OrderDate = x.o.OrderDate,
                    Status = x.o.Status,
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<OrderVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<int> Delete(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null) throw new shopException($"Cannot find a order: {orderId}");

            _context.Orders.Remove(order);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateStatus(OrderUpdateRequest request)
        {
            var order = await _context.Orders.FindAsync(request.Id);
            if (order == null) throw new shopException($"Cannot find a product with id: {order}");
            order.Status = request.Status;
            return await _context.SaveChangesAsync();
        }
    }
}