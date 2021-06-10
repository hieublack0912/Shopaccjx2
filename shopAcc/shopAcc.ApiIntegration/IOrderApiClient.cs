using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<PagedResult<OrderVm>> GetPagings(GetOrderPagingRequest request);

        Task<PagedResult<OrderVm>> GetUserPagings(GetOrderUserPagingRequest request);

        Task<bool> CreateOrder(OrderCreateRequest request);

        Task<OrderVm> GetById(int id);

        Task<bool> DeleteOrder(int id);

        Task<bool> UpdateStatus(OrderUpdateRequest request);
    }
}