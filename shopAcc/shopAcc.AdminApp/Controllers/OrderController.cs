using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shopAcc.ApiIntegration;
using shopAcc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.AdminApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;
        private readonly IConfiguration _configuration;

        private readonly ICategoryApiClient _categoryApiClient;

        public OrderController(IOrderApiClient orderApiClient,
            IConfiguration configuration,
            ICategoryApiClient categoryApiClient)
        {
            _configuration = configuration;
            _orderApiClient = orderApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetOrderPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
            var data = await _orderApiClient.GetPagings(request);
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
        public async Task<IActionResult> Create([FromForm] OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _orderApiClient.CreateOrder(request);
            if (result)
            {
                TempData["result"] = "Thêm mới đơn hàng thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm đơn hàng thất bại");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderApiClient.GetById(id);
            var editVm = new OrderUpdateRequest()
            {
                Id = order.Id,
                Status = order.Status,
            };
            return View(editVm);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] OrderUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _orderApiClient.UpdateStatus(request);
            if (result)
            {
                TempData["result"] = "Cập nhật Trạng thái thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật Trạng thái thất bại");
            return View(request);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(new OrderDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(OrderDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _orderApiClient.DeleteOrder(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa đơn hàng thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
    }
}