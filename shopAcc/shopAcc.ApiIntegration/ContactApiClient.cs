using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public class ContactApiClient : BaseApiClient, IContactApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ContactApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<PagedResult<ContactVm>> GetPagings(GetContactPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ContactVm>>(
                $"/api/contacts/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");

            return data;
        }

        public async Task<ContactVm> GetById(int id)
        {
            return await GetAsync<ContactVm>($"/api/contacts/{id}");
        }

        public async Task<bool> CreateContact(ContactCreateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);

            var requestContent = new MultipartFormDataContent();

            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Name) ? "" : request.Name.ToString()), "Name");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Email) ? "" : request.Email.ToString()), "Email");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.PhoneNumber) ? "" : request.PhoneNumber.ToString()), "PhoneNumber");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Message) ? "" : request.Message.ToString()), "Message");

            requestContent.Add(new StringContent(request.Status.ToString()), "Status");
            var response = await client.PostAsync($"/api/contacts/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateContact(ContactUpdateRequest request)
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
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.Email) ? "" : request.Email.ToString()), "Email");
            requestContent.Add(new StringContent(string.IsNullOrEmpty(request.PhoneNumber) ? "" : request.PhoneNumber.ToString()), "PhoneNumber");

            requestContent.Add(new StringContent(request.Status.ToString()), "Status");

            var response = await client.PutAsync($"/api/contacts/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteContact(int id)
        {
            return await Delete($"/api/contacts/" + id);
        }
    }
}