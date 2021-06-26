using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shopAcc.ApiIntegration;
using shopAcc.ViewModels.Utilities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string name, string email, string phoneNumber, string message)
        {
            var request = new ContactCreateRequest
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber,
                Message = message
            };
            if (!ModelState.IsValid)
            {
                ModelState.Clear();
                ModelState.AddModelError("", "Vui lòng nhập đầy đủ các trường");
                return View(request);
            }

            var result = await _contactApiClient.CreateContact(request);
            if (result)
            {
                MailMessage mess = new MailMessage("vth09121997@gmail.com", "hieublack0912@gmail.com", "Thông báo có người cần hỗ trợ", $"Một người dùng vừa gửi yêu cầu hỗ trợ");
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("vth09121997@gmail.com", "l0velyhd97");
                client.Send(mess);
                TempData["Message"] = "Hỗ trợ đã được gửi đến admin thành công. Admin sẽ phản hồi lại ngay khi có thể";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Gửi hỗ trợ thất bại. Vui lòng gửi lại");
            return View(request);
        }
    }
}