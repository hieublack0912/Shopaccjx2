using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public class OrderApiClient : BaseApiClient, IOrderApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public OrderApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> CreateOrder(OrderCreateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            requestContent.Add(new StringContent(request.UserId.ToString()), "UserId");
            requestContent.Add(new StringContent(request.Price.ToString()), "Price");
            requestContent.Add(new StringContent(request.AccountId.ToString()), "AccountId");

            var response = await client.PostAsync($"/api/orders/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<OrderVm> GetById(int id)
        {
            var data = await GetAsync<OrderVm>($"/api/orders/{id}");

            return data;
        }

        public async Task<PagedResult<OrderVm>> GetPagings(GetOrderPagingRequest request)
        {
            var data = await GetAsync<PagedResult<OrderVm>>(
                $"/api/orders/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");

            return data;
        }

        public async Task<PagedResult<OrderVm>> GetUserPagings(GetOrderUserPagingRequest request)
        {
            var data = await GetAsync<PagedResult<OrderVm>>(
                $"/api/orders/accountby?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&userName={request.UserName}");

            return data;
        }

        public async Task<bool> DeleteOrder(int id)
        {
            return await Delete($"/api/orders/" + id);
        }

        public async Task<bool> UpdateStatus(OrderUpdateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);

            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(request.Status.ToString()), "Status");
            var response = await client.PutAsync($"/api/orders/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }
    }
}