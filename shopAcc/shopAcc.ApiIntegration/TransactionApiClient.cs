using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public class TransactionApiClient : BaseApiClient, ITransactionApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public TransactionApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> CreateTransaction(TransactionCreateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            var requestContent = new MultipartFormDataContent();

            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.ExternalTransactionId) ? "" : request.ExternalTransactionId.ToString()), "ExternalTransactionId");
            requestContent.Add(new StringContent(request.Amount.ToString()), "Amount");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Result) ? "" : request.Result.ToString()), "Result");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Message) ? "" : request.Message.ToString()), "Message");
            requestContent.Add(new StringContent(request.UserId.ToString()), "UserId");

            var response = await client.PostAsync($"/api/transactions/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<PagedResult<TransactionVm>> GetPagings(GetTransactionPagingRequest request)
        {
            var data = await GetAsync<PagedResult<TransactionVm>>(
                $"/api/transactions/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&userName={request.UserName}");

            return data;
        }

        public async Task<TransactionVm> GetById(int id)
        {
            var data = await GetAsync<TransactionVm>($"/api/transactions/{id}");

            return data;
        }
    }
}