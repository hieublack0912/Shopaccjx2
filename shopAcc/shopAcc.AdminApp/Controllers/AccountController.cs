using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using shopAcc.ApiIntegration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Catalog.AccountImages;
using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.ViewModels.Common;

namespace shopAcc.AdminApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountApiClient _accountApiClient;
        private readonly IConfiguration _configuration;

        private readonly ICategoryApiClient _categoryApiClient;

        public AccountController(IAccountApiClient accountApiClient,
            IConfiguration configuration,
            ICategoryApiClient categoryApiClient)
        {
            _configuration = configuration;
            _accountApiClient = accountApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int? categoryId, int pageIndex = 1, int pageSize = 20)
        {
            var request = new GetManageAccountPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                CategoryId = categoryId
            };
            var data = await _accountApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

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
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] AccountCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _accountApiClient.CreateAccount(request);
            if (result)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryAssign(int id)
        {
            var roleAssignRequest = await GetCategoryAssignRequest(id);
            return View(roleAssignRequest);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAssign(CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _accountApiClient.CategoryAssign(request.Id, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetCategoryAssignRequest(request.Id);

            return View(roleAssignRequest);
        }

        [HttpGet]
        public IActionResult AddImage(int id)
        {
            var editVm = new AccountImageCreateRequest()
            {
                AccountId = id,
            };
            return View(editVm);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> AddImage([FromForm] AccountImageCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _accountApiClient.AddImage(request);

            if (result)
            {
                TempData["result"] = "Thêm mới ảnh account thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm ảnh account thất bại");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> AllImage(int id)
        {
            var image = await _accountApiClient.GetListImages(id);
            return View(image);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var account = await _accountApiClient.GetById(id);
            var editVm = new AccountUpdateRequest()
            {
                Id = account.Id,
                Price = account.Price,
                Description = account.Description,
                Title = account.Title,
                Reincarnation = account.Reincarnation,
                Visional = account.Visional,
                UserNameAcc = account.UserNameAcc,
                PasswordAcc = account.PasswordAcc,
                IsFeatured = account.IsFeatured,
            };
            return View(editVm);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] AccountUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _accountApiClient.UpdateAccount(request);
            if (result)
            {
                TempData["result"] = "Cập nhật sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            return View(request);
        }

        private async Task<CategoryAssignRequest> GetCategoryAssignRequest(int id)
        {
            var productObj = await _accountApiClient.GetById(id);
            var categories = await _categoryApiClient.GetAll();
            var categoryAssignRequest = new CategoryAssignRequest();
            foreach (var role in categories)
            {
                categoryAssignRequest.Categories.Add(new SelectItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    Selected = productObj.Categories.Contains(role.Name)
                });
            }
            return categoryAssignRequest;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(new AccountDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AccountDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _accountApiClient.DeleteAccount(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }

        [HttpGet]
        public IActionResult DeleteImage(int id)
        {
            return View(new AccountDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteImage(AccountDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _accountApiClient.DeleteImage(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa ảnh thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa ảnh không thành công");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var account = await _accountApiClient.GetById(id);
            var editVm = new AccountVm()
            {
                Id = account.Id,
                Price = account.Price,
                DateCreated = account.DateCreated,
                Description = account.Description,
                Title = account.Title,
                Reincarnation = account.Reincarnation,
                Visional = account.Visional,
                UserNameAcc = account.UserNameAcc,
                PasswordAcc = account.PasswordAcc,
                IsFeatured = account.IsFeatured,
                ThumbnailImage = account.ThumbnailImage,
                UserCreate = account.UserCreate,
                Categories = account.Categories
            };
            return View(editVm);
        }
    }
}