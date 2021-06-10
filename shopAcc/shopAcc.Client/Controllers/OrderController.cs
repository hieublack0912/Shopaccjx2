using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shopAcc.ApiIntegration;
using shopAcc.Client.Models;
using shopAcc.ViewModels.Catalog.AccountBalances;
using shopAcc.ViewModels.Sales;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBalanceApiClient _balanceApiClient;
        private readonly IConfiguration _configuration;
        private readonly IUserApiClient _userApiClient;
        private readonly IAccountApiClient _accountApiClient;
        private readonly ITransactionApiClient _transactionApiClient;
        private readonly IOrderApiClient _orderApiClient;

        public OrderController(IBalanceApiClient balanceApiClient, IAccountApiClient accountApiClient,
            IConfiguration configuration, IUserApiClient userApiClient, IOrderApiClient orderApiClient,
            ITransactionApiClient transactionApiClient)
        {
            _configuration = configuration;
            _balanceApiClient = balanceApiClient;
            _userApiClient = userApiClient;
            _accountApiClient = accountApiClient;
            _orderApiClient = orderApiClient;
            _transactionApiClient = transactionApiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Checkout(int accountId)
        {
            if (User.Identity.Name == null)
            {
                TempData["Message"] = "Vui lòng đăng nhập";
                return RedirectToAction("Login", "User");
            }
            var user = await _userApiClient.GetByName(User.Identity.Name);
            var balance = await _balanceApiClient.GetByIdUser(user.ResultObj.Id);
            var account = await _accountApiClient.GetById(accountId);
            var all = new CheckoutView()
            {
                AccountId = account.Id,
                UserId = user.ResultObj.Id,
                Title = account.Title,
                Price = account.Price,
                Balance = balance.Balance
            };

            if (balance.Balance < account.Price)
            {
                TempData["Message"] = "Tài khoản của quý khách không đủ để thực hiện giao dịch vui lòng nạp tiền để có thể thực hiện giao dịch.";

                return RedirectToAction("Banking", "Pay");
            }

            return View(all);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Checkout([FromForm] OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var balance = await _balanceApiClient.GetByIdUser(request.UserId);
            var req = new BalanceUpdateRequest()
            {
                Id = balance.Id,
                UserId = balance.UserId,
                BalanceUpdate = request.Price
            };
            var endbalance = await _balanceApiClient.ClearBalance(req);
            if (!endbalance)
            {
                ModelState.AddModelError("", "giao dịch thất bại");
                return View(request);
            }
            var result = await _orderApiClient.CreateOrder(request);
            if (result)
            {
                var nosell = await _accountApiClient.NoSell(request.AccountId);
                var account = await _accountApiClient.GetById(request.AccountId);
                var history = new TransactionCreateRequest()
                {
                    ExternalTransactionId = "null",
                    Amount = request.Price,
                    Result = "Thành Công",
                    Message = $"Mua account {account.Title}",
                    Status = 0,
                    UserId = request.UserId
                };
                await _transactionApiClient.CreateTransaction(history);

                MailMessage mess = new MailMessage("vth09121997@gmail.com", "hieublack0912@gmail.com", "Thông báo có người mua tk", $"Người dùng {User.Identity.Name} vừa mua tk {request.AccountId}");
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("vth09121997@gmail.com", "l0velyhd97");
                client.Send(mess);
                TempData["Message"] = "Giao dịch thành công. Admin sẽ liên hệ bạn sớm để làm thông tin account. Bạn có thể vào phần account đã mua để kiểm tra.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm đơn hàng thất bại");
            return View(request);
        }
    }
}