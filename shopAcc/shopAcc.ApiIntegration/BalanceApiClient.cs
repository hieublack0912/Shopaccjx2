using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Catalog.AccountBalances;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public class BalanceApiClient : BaseApiClient, IBalanceApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public BalanceApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<PagedResult<BalanceVm>> GetPagings(GetBalancePagingRequest request)
        {
            var data = await GetAsync<PagedResult<BalanceVm>>(
                $"/api/balances/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");

            return data;
        }

        public async Task<List<BalanceVm>> GetAll()
        {
            return await GetListAsync<BalanceVm>("/api/balances");
        }

        public async Task<bool> UpdateBalance(BalanceUpdateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(request.BalanceUpdate.ToString()), "BalanceUpdate");
            var response = await client.PatchAsync($"/api/balances/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ClearBalance(BalanceUpdateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);

            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(request.BalanceUpdate.ToString()), "BalanceUpdate");
            var response = await client.PatchAsync($"/api/balances/clear/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<BalanceVm> GetById(int id)
        {
            var data = await GetAsync<BalanceVm>($"/api/balances/{id}");

            return data;
        }

        public async Task<BalanceVm> GetByIdUser(Guid id)
        {
            var data = await GetAsync<BalanceVm>($"/api/balances/user/{id}");

            return data;
        }
    }
}