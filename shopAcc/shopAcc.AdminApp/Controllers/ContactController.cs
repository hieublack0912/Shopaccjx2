using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shopAcc.ApiIntegration;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.AdminApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IConfiguration _configuration;

        private readonly IContactApiClient _contactApiClient;

        public ContactController(
            IConfiguration configuration,
            IContactApiClient contactApiClient)
        {
            _configuration = configuration;
            _contactApiClient = contactApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetContactPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
            var data = await _contactApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ContactCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _contactApiClient.CreateContact(request);
            if (result)
            {
                TempData["result"] = "Thêm mới liên hệ thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm liên hệ thất bại");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var contact = await _contactApiClient.GetById(id);

            var editVm = new ContactUpdateRequest()
            {
                Id = contact.Id,
                Name = contact.Name,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber,
                Status = contact.Status
            };
            return View(editVm);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] ContactUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _contactApiClient.UpdateContact(request);
            if (result)
            {
                TempData["result"] = "Cập nhật liên hệ thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật liên hệ thất bại");
            return View(request);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(new ContactDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ContactDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _contactApiClient.DeleteContact(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa Contact thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
    }
}