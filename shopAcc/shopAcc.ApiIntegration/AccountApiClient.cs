using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public class AccountApiClient : BaseApiClient, IAccountApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AccountApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> CreateAccount(AccountCreateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var nameCreate = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultName);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }

            requestContent.Add(new StringContent(request.Price.ToString()), "Price");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Title) ? "" : request.Title.ToString()), "Title");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Description) ? "" : request.Description.ToString()), "Description");

            requestContent.Add(new StringContent(request.Reincarnation.ToString()), "Reincarnation");
            requestContent.Add(new StringContent(request.Visional.ToString()), "Visional");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.UserNameAcc) ? "" : request.UserNameAcc.ToString()), "UserNameAcc");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.PasswordAcc) ? "" : request.PasswordAcc.ToString()), "PasswordAcc");
            requestContent.Add(new StringContent(nameCreate), "UserCreate");

            var response = await client.PostAsync($"/api/accounts/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAccount(AccountUpdateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }

            //requestContent.Add(new StringContent(request.Id.ToString()), "id");
            requestContent.Add(new StringContent(request.Price.ToString()), "Price");

            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Title) ? "" : request.Title.ToString()), "Title");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Description) ? "" : request.Description.ToString()), "Description");

            requestContent.Add(new StringContent(request.Reincarnation.ToString()), "Reincarnation");
            requestContent.Add(new StringContent(request.Visional.ToString()), "Visional");
            requestContent.Add(new StringContent(request.IsFeatured.ToString()), "IsFeatured");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.UserNameAcc) ? "" : request.UserNameAcc.ToString()), "UserNameAcc");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.PasswordAcc) ? "" : request.PasswordAcc.ToString()), "PasswordAcc");

            var response = await client.PutAsync($"/api/accounts/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateView(int Id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);

            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(Id.ToString()), "Id");

            var response = await client.PutAsync($"/api/accounts/add/" + Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> NoSell(int Id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);

            var requestContent = new MultipartFormDataContent();
            requestContent.Add(new StringContent(Id.ToString()), "Id");

            var response = await client.PutAsync($"/api/accounts/nosell/" + Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<PagedResult<AccountVm>> GetPagings(GetManageAccountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AccountVm>>(
                $"/api/accounts/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&categoryId={request.CategoryId}&valuerange={request.ValueRange}");

            return data;
        }

        public async Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"/api/accounts/{id}/categories", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<AccountVm> GetById(int id)
        {
            var data = await GetAsync<AccountVm>($"/api/accounts/{id}");

            return data;
        }

        public async Task<List<AccountVm>> GetFeaturedAccounts(int take)
        {
            var data = await GetListAsync<AccountVm>($"/api/accounts/featured/{take}");
            return data;
        }

        public async Task<List<AccountVm>> GetLatestAccounts(int take)
        {
            var data = await GetListAsync<AccountVm>($"/api/accounts/latest/{take}");
            return data;
        }

        public async Task<bool> DeleteAccount(int id)
        {
            return await Delete($"/api/accounts/" + id);
        }
    }
}