using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shopAcc.ApiIntegration;
using shopAcc.Client.Models;
using shopAcc.ViewModels.Catalog.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountApiClient _accountApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public AccountController(IAccountApiClient accountApiClient, ICategoryApiClient categoryApiClient)
        {
            _accountApiClient = accountApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int? categoryId, int? valueRange, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetManageAccountPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                CategoryId = categoryId,
                ValueRange = valueRange
            };
            var data = await _accountApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;
            if (data.Items.Count == 0)
            {
                TempData["Message"] = "Không có tài khoản nào phù hợp với yêu cầu của quý khách.";
            }
            var categories = await _categoryApiClient.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.Id
            });

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(new AccountCategoryViewModel()
            {
                Category = null,
                Accounts = data
            });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var a = await _accountApiClient.UpdateView(id);
            var account = await _accountApiClient.GetById(id);
            return View(new AccountDetailViewModel()
            {
                Account = account,
                Category = await _categoryApiClient.GetById(id)
            });
        }

        public async Task<IActionResult> Category(int id, string keyWord, int valueRange)
        {
            if (id == 0)
            {
                var routeValues = new GetManageAccountPagingRequest()
                {
                    Keyword = keyWord,
                    PageIndex = 1,
                    PageSize = 10,
                    CategoryId = 0,
                    ValueRange = valueRange
                };
                return RedirectToAction("Index", routeValues);
            }
            var accounts = await _accountApiClient.GetPagings(new GetManageAccountPagingRequest()
            {
                CategoryId = id,
                PageIndex = 1,
                PageSize = 10,
                Keyword = keyWord,
                ValueRange = valueRange
            });
            if (accounts.Items.Count == 0)
            {
                TempData["Message"] = "Không có tài khoản nào phù hợp với yêu cầu của quý khách.";
            }
            return View(new AccountCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(id),
                Accounts = accounts
            });
        }
    }
}