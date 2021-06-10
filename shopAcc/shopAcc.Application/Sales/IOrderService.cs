using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Sales
{
    public interface IOrderService
    {
        Task<int> Create(OrderCreateRequest request);

        Task<PagedResult<OrderVm>> GetAllPaging(GetOrderPagingRequest request);

        Task<OrderVm> GetById(int orderId);

        Task<PagedResult<OrderVm>> GetAllByUser(GetOrderUserPagingRequest request);

        Task<int> Delete(int orderId);

        Task<int> UpdateStatus(OrderUpdateRequest request);
    }
}