using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopAcc.Application.Sales;
using shopAcc.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(
            IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetOrderPagingRequest request)
        {
            var orders = await _orderService.GetAllPaging(request);
            return Ok(orders);
        }

        [HttpGet("accountby")]
        public async Task<IActionResult> GetAllByUser([FromQuery] GetOrderUserPagingRequest request)
        {
            var orders = await _orderService.GetAllByUser(request);
            return Ok(orders);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var orderId = await _orderService.Create(request);
            if (orderId == 0)
                return BadRequest();

            var order = await _orderService.GetById(orderId);

            return CreatedAtAction(nameof(GetById), new { id = orderId }, order);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetById(int orderId)
        {
            var order = await _orderService.GetById(orderId);
            if (order == null)
                return BadRequest("Cannot find product");
            return Ok(order);
        }

        [HttpDelete("{orderId}")]
        [Authorize]
        public async Task<IActionResult> Delete(int orderId)
        {
            var affectedResult = await _orderService.Delete(orderId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{orderId}")]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int orderId, [FromForm] OrderUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = orderId;
            var affectedResult = await _orderService.UpdateStatus(request);
            if (affectedResult != 0)
                return Ok();
            return BadRequest();
        }
    }
}