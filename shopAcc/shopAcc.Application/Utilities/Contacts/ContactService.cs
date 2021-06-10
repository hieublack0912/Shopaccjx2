using Microsoft.EntityFrameworkCore;
using shopAcc.Data.EF;
using shopAcc.Data.Entities;
using shopAcc.Data.Enums;
using shopAcc.Utilities.Exceptions;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Utilities.Contacts
{
    public class ContactService : IContactService
    {
        private readonly EShopDbContext _context;

        public ContactService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ContactCreateRequest request)
        {
            var contact = new Contact()
            {
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Message = request.Message,
                Status = Status.InActive
            };
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return contact.Id;
        }

        public async Task<int> Delete(int Id)
        {
            var contact = await _context.Contacts.FindAsync(Id);
            if (contact == null) throw new shopException($"Cannot find a Contact: {Id}");

            _context.Contacts.Remove(contact);

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ContactVm>> GetAllPaging(GetContactPagingRequest request)
        {
            var query = from c in _context.Contacts
                        select new { c };
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.c.Name.Contains(request.Keyword));

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ContactVm()
                {
                    Id = x.c.Id,
                    Name = x.c.Name,
                    Email = x.c.Email,
                    PhoneNumber = x.c.PhoneNumber,
                    Message = x.c.Message,
                    Status = x.c.Status,
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ContactVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ContactVm> GetById(int Id)
        {
            var query = from c in _context.Contacts
                        where c.Id == Id
                        select new { c };
            return await query.Select(x => new ContactVm()
            {
                Id = x.c.Id,
                Name = x.c.Name,
                Email = x.c.Email,
                PhoneNumber = x.c.PhoneNumber,
                Message = x.c.Message,
                Status = x.c.Status,
            }).FirstOrDefaultAsync();
        }

        public async Task<int> Update(ContactUpdateRequest request)
        {
            var contact = await _context.Contacts.FindAsync(request.Id);
            if (contact == null) throw new shopException($"Cannot find a Contact with id: {request.Id}");

            contact.Name = request.Name;
            contact.Email = request.Email;
            contact.PhoneNumber = request.PhoneNumber;
            contact.Status = request.Status;

            return await _context.SaveChangesAsync();
        }
    }
}