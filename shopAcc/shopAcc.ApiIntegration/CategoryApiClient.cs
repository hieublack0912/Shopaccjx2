using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Catalog.Categories;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<CategoryVm>> GetAll()
        {
            return await GetListAsync<CategoryVm>("/api/categories");
        }

        public async Task<PagedResult<CategoryVm>> GetPagings(GetCategoryPagingRequest request)
        {
            var data = await GetAsync<PagedResult<CategoryVm>>(
                $"/api/categories/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");

            return data;
        }

        public async Task<CategoryVm> GetById(int id)
        {
            return await GetAsync<CategoryVm>($"/api/categories/{id}");
        }

        public async Task<bool> CreateCategory(CategoryCreateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Name) ? "" : request.Name.ToString()), "Name");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.SeoDescription) ? "" : request.SeoDescription.ToString()), "SeoDescription");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.SeoAlias) ? "" : request.SeoAlias.ToString()), "SeoAlias");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.SeoTitle) ? "" : request.SeoAlias.ToString()), "SeoTitle");

            requestContent.Add(new StringContent(request.SortOrder.ToString()), "SortOrder");
            requestContent.Add(new StringContent(request.IsShowOnHome.ToString()), "IsShowOnHome");
            requestContent.Add(new StringContent(request.ParentId.ToString()), "ParentId");

            var response = await client.PostAsync($"/api/categories/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateCategory(CategoryUpdateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            //requestContent.Add(new StringContent(request.Id.ToString()), "id");

            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Name) ? "" : request.Name.ToString()), "Name");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.SeoDescription) ? "" : request.SeoDescription.ToString()), "SeoDescription");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.SeoTitle) ? "" : request.SeoTitle.ToString()), "SeoTitle");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.SeoAlias) ? "" : request.SeoAlias.ToString()), "SeoAlias");

            requestContent.Add(new StringContent(request.SortOrder.ToString()), "SortOrder");
            requestContent.Add(new StringContent(request.IsShowOnHome.ToString()), "IsShowOnHome");
            requestContent.Add(new StringContent(request.Status.ToString()), "Status");
            requestContent.Add(new StringContent(request.ParentId.ToString()), "ParentId");

            var response = await client.PutAsync($"/api/categories/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            return await Delete($"/api/categories/" + id);
        }
    }
}