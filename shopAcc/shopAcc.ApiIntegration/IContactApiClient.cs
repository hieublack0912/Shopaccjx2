using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface IContactApiClient
    {
        Task<PagedResult<ContactVm>> GetPagings(GetContactPagingRequest request);

        Task<ContactVm> GetById(int id);

        Task<bool> CreateContact(ContactCreateRequest request);

        Task<bool> UpdateContact(ContactUpdateRequest request);

        Task<bool> DeleteContact(int id);
    }
}