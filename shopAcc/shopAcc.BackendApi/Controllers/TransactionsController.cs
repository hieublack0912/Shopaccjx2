using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopAcc.Application.System.Transactions;
using shopAcc.ViewModels.System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(
            ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetTransactionPagingRequest request)
        {
            var transactions = await _transactionService.GetAllPaging(request);
            return Ok(transactions);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] TransactionCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var transId = await _transactionService.Create(request);
            if (transId == 0)
                return BadRequest();

            var transaction = await _transactionService.GetById(transId);

            return CreatedAtAction(nameof(GetById), new { id = transId }, transaction);
        }

        [HttpGet("{transId}")]
        public async Task<IActionResult> GetById(int transId)
        {
            var transaction = await _transactionService.GetById(transId);
            if (transaction == null)
                return BadRequest("Cannot find transaction");
            return Ok(transaction);
        }
    }
}