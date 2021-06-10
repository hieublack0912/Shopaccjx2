using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopAcc.Application.Utilities.Contacts;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(
            IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetContactPagingRequest request)
        {
            var contacts = await _contactService.GetAllPaging(request);
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _contactService.GetById(id);
            return Ok(contact);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ContactCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var contactId = await _contactService.Create(request);
            if (contactId == 0)
                return BadRequest();

            var contact = await _contactService.GetById(contactId);

            return CreatedAtAction(nameof(GetById), new { id = contactId }, contact);
        }

        [HttpPut("{contactId}")]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int contactId, [FromForm] ContactUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = contactId;
            var affectedResult = await _contactService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{Id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int Id)
        {
            var affectedResult = await _contactService.Delete(Id);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}