using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopAcc.Application.Catalog.AccountBalances;
using shopAcc.ViewModels.Catalog.AccountBalances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalancesController : ControllerBase
    {
        private readonly IBalanceService _balanceService;

        public BalancesController(
            IBalanceService balanceService)
        {
            _balanceService = balanceService;
        }

        [HttpPatch("{balanceId}")]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> UpdateBalance([FromRoute] int balanceId, [FromForm] BalanceUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = balanceId;
            var isSuccessful = await _balanceService.UpdateBalance(request);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

        [HttpPatch("clear/{balanceId}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> ClearBalance([FromRoute] int balanceId, [FromForm] BalanceUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = balanceId;
            var isSuccessful = await _balanceService.ClearBalance(request);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

        [HttpGet("paging")]
        [Authorize]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetBalancePagingRequest request)
        {
            var accounts = await _balanceService.GetAllPaging(request);
            return Ok(accounts);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var accounts = await _balanceService.GetAll();
            return Ok(accounts);
        }

        [HttpGet("{balanceId}")]
        public async Task<IActionResult> GetById(int balanceId)
        {
            var account = await _balanceService.GetById(balanceId);
            if (account == null)
                return BadRequest("Cannot find product");
            return Ok(account);
        }

        [HttpGet("user/{UserId}")]
        public async Task<IActionResult> GetById(Guid UserId)
        {
            var account = await _balanceService.GetByIdUser(UserId);
            if (account == null)
                return BadRequest("Cannot find product");
            return Ok(account);
        }
    }
}