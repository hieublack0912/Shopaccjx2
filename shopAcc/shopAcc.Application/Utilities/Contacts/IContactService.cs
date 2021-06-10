using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Utilities.Contacts
{
    public interface IContactService
    {
        Task<PagedResult<ContactVm>> GetAllPaging(GetContactPagingRequest request);

        Task<int> Create(ContactCreateRequest request);

        Task<ContactVm> GetById(int Id);

        Task<int> Update(ContactUpdateRequest request);

        Task<int> Delete(int Id);
    }
}