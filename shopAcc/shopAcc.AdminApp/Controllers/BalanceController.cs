using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using shopAcc.ApiIntegration;
using shopAcc.ViewModels.Catalog.AccountBalances;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.AdminApp.Controllers
{
    public class BalanceController : Controller
    {
        private readonly IBalanceApiClient _balanceApiClient;
        private readonly IConfiguration _configuration;

        private readonly ICategoryApiClient _categoryApiClient;
        private readonly ITransactionApiClient _transactionApiClient;

        public BalanceController(IBalanceApiClient balanceApiClient,
            IConfiguration configuration,
            ICategoryApiClient categoryApiClient,
            ITransactionApiClient transactionApiClient)
        {
            _configuration = configuration;
            _balanceApiClient = balanceApiClient;
            _categoryApiClient = categoryApiClient;
            _transactionApiClient = transactionApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetBalancePagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
            var data = await _balanceApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var account = await _balanceApiClient.GetById(id);
            var editVm = new BalanceUpdateRequest()
            {
                Id = account.Id,
                UserName = account.UserName,
                UserId = account.UserId,
                BalanceUpdate = 0
            };
            return View(editVm);
        }

        [HttpPost]
        public async Task<IActionResult> Update(BalanceUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _balanceApiClient.UpdateBalance(request);
            if (result)
            {
                TempData["result"] = "Cập nhật số dư thành công";
                var req = new TransactionCreateRequest()
                {
                    ExternalTransactionId = "null",
                    Amount = request.BalanceUpdate,
                    Result = "Thành Công",
                    Message = (request.BalanceUpdate > 0) ? "Nạp tiền vào tài khoản" : "Admin Trừ tiền tài khoản",
                    Status = 0,
                    UserId = request.UserId
                };
                await _transactionApiClient.CreateTransaction(req);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật số dư thất bại");
            return View(request);
        }
    }
}