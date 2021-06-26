using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shopAcc.Application.Catalog.Accounts;
using shopAcc.ViewModels.Catalog.AccountImages;
using shopAcc.ViewModels.Catalog.Accounts;
using System.Threading.Tasks;

namespace shopAcc.BackendApi.Controllers
{
    //api/products
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(
            IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageAccountPagingRequest request)
        {
            var accounts = await _accountService.GetAllPaging(request);
            return Ok(accounts);
        }

        [HttpGet("{accountId}")]
        public async Task<IActionResult> GetById(int accountId)
        {
            var account = await _accountService.GetById(accountId);
            if (account == null)
                return BadRequest("Cannot find product");
            return Ok(account);
        }

        [HttpGet("featured/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeaturedAccounts(int take)
        {
            var accounts = await _accountService.GetFeaturedAccounts(take);
            return Ok(accounts);
        }

        [HttpGet("latest/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLatestAccounts(int take)
        {
            var accounts = await _accountService.GetLatestAccounts(take);
            return Ok(accounts);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] AccountCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var accountId = await _accountService.Create(request);
            if (accountId == 0)
                return BadRequest();

            var account = await _accountService.GetById(accountId);

            return CreatedAtAction(nameof(GetById), new { id = accountId }, account);
        }

        [HttpPut("{accountId}")]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int accountId, [FromForm] AccountUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = accountId;
            var affectedResult = await _accountService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{accountId}")]
        [Authorize]
        public async Task<IActionResult> Delete(int accountId)
        {
            var affectedResult = await _accountService.Delete(accountId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("add/{accountId}")]
        [AllowAnonymous]
        public async Task<IActionResult> Updateview(int accountId)
        {
            var isSuccessful = await _accountService.AddViewcount(accountId);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

        [HttpPut("nosell/{accountId}")]
        [AllowAnonymous]
        public async Task<IActionResult> NoSell(int accountId, bool status)
        {
            var isSuccessful = await _accountService.NoSell(accountId, status);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

        //Images
        [HttpPost("{accountId}/images")]
        public async Task<IActionResult> CreateImage(int accountId, [FromForm] AccountImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _accountService.AddImage(accountId, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _accountService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{accountId}/images/{imageId}")]
        [Authorize]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] AccountImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _accountService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("images/{imageId}")]
        [Authorize]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _accountService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpGet("{accountId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int accountId, int imageId)
        {
            var image = await _accountService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }

        [HttpGet("{accountId}/images/")]
        public async Task<IActionResult> GetImage(int accountId)
        {
            var image = await _accountService.GetListImages(accountId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }

        [HttpPut("{id}/categories")]
        [Authorize]
        public async Task<IActionResult> CategoryAssign(int id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _accountService.CategoryAssign(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}