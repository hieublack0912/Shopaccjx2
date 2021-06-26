using shopAcc.Application.Common;
using shopAcc.Data.EF;
using shopAcc.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using shopAcc.Application.Catalog.Accounts;
using shopAcc.ViewModels.Catalog.AccountImages;
using shopAcc.Data.Entities;
using shopAcc.ViewModels.Catalog.Accounts;
using shopAcc.Utilities.Exceptions;
using shopAcc.ViewModels.Common;

namespace shopAcc.Application.Catalog.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly EShopDbContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";

        public AccountService(EShopDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int accountId, AccountImageCreateRequest request)
        {
            var query = from ai in _context.AccountImages
                        where ai.AccountId == accountId
                        select new { ai };
            var sortOrder = await query.CountAsync();
            var accountImage = new AccountImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                IsDefault = false,
                AccountId = accountId,
                SortOrder = sortOrder + 1
            };

            if (request.ImageFile != null)
            {
                accountImage.ImagePath = await this.SaveFile(request.ImageFile);
                accountImage.FileSize = request.ImageFile.Length;
            }
            _context.AccountImages.Add(accountImage);
            await _context.SaveChangesAsync();
            return accountImage.Id;
        }

        public async Task<bool> AddViewcount(int accountId)
        {
            var account = await _context.Accounts.FindAsync(accountId);
            account.ViewCount += 1;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> NoSell(int accountId, bool status)
        {
            var account = await _context.Accounts.FindAsync(accountId);
            if (!status)
            {
                account.IsFeatured = false;
            }
            else
                account.IsFeatured = true;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> Create(AccountCreateRequest request)
        {
            if (request.Price < 0)
                throw new shopException($"Cannot Create product");
            var product = new Account()
            {
                Price = request.Price,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                Title = request.Title,
                Description = request.Description,
                Reincarnation = request.Reincarnation,
                Visional = request.Visional,
                UserNameAcc = request.UserNameAcc,
                PasswordAcc = request.PasswordAcc,
                UserCreate = request.UserCreate,
                IsFeatured = true
            };
            //Save image
            if (request.ThumbnailImage != null)
            {
                product.AccountImages = new List<AccountImage>()
                {
                    new AccountImage()
                    {
                        Caption = "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }
            _context.Accounts.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<int> Delete(int AccountId)
        {
            var account = await _context.Accounts.FindAsync(AccountId);
            if (account == null) throw new shopException($"Cannot find a account game: {AccountId}");

            var images = _context.AccountImages.Where(i => i.AccountId == AccountId);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Accounts.Remove(account);

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<AccountVm>> GetAllPaging(GetManageAccountPagingRequest request)
        {
            //1. Select join
            var query = (from a in _context.Accounts
                         join aic in _context.AccountInCategories on a.Id equals aic.AccountId into aaic
                         from aic in aaic.DefaultIfEmpty()
                         join c in _context.Categories on aic.CategoryId equals c.Id into picc
                         from c in picc.DefaultIfEmpty()
                         join ai in _context.AccountImages on a.Id equals ai.AccountId into aai
                         from ai in aai.DefaultIfEmpty()
                         where ai.IsDefault == true
                         select new { a, aic, ai });
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.a.Title.Contains(request.Keyword));
            if (request.CategoryId != null && request.CategoryId != 0)
            {
                query = query.Where(p => p.aic.CategoryId == request.CategoryId);
            }

            if (request.ValueRange != null && request.ValueRange != 0)
            {
                if (request.ValueRange == 1)
                    query = query.Where(p => p.a.Price <= 500000);
                else if (request.ValueRange == 2)
                    query = query.Where(p => p.a.Price <= 5000000 && p.a.Price >= 500000);
                else if (request.ValueRange == 3)
                    query = query.Where(p => p.a.Price <= 20000000 && p.a.Price >= 5000000);
                else
                    query = query.Where(p => p.a.Price >= 20000000);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new AccountVm()
                {
                    Id = x.a.Id,
                    Title = x.a.Title,
                    Price = x.a.Price,
                    DateCreated = x.a.DateCreated,
                    Description = x.a.Description,
                    Reincarnation = x.a.Reincarnation,
                    Visional = x.a.Visional,
                    UserNameAcc = x.a.UserNameAcc,
                    PasswordAcc = x.a.PasswordAcc,
                    ViewCount = x.a.ViewCount,
                    ThumbnailImage = x.ai.ImagePath,
                    IsFeatured = x.a.IsFeatured,
                    UserCreate = x.a.UserCreate
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AccountVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<AccountVm> GetById(int accountId)
        {
            var account = await _context.Accounts.FindAsync(accountId);

            var categories = await (from c in _context.Categories
                                    join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                                    join aic in _context.AccountInCategories on c.Id equals aic.CategoryId
                                    where aic.AccountId == accountId
                                    select ct.Name).ToListAsync();

            var image = await _context.AccountImages.Where(x => x.AccountId == accountId && x.IsDefault == true).FirstOrDefaultAsync();

            var acccountViewModel = new AccountVm()
            {
                Id = account.Id,
                DateCreated = account.DateCreated,
                Description = account != null ? account.Description : null,
                Title = account != null ? account.Title : null,
                Price = account.Price,
                Reincarnation = account.Reincarnation,
                Visional = account.Visional,
                ViewCount = account.ViewCount,
                UserNameAcc = account.UserNameAcc,
                PasswordAcc = account.PasswordAcc,
                Categories = categories,
                UserCreate = account.UserCreate,
                IsFeatured = account.IsFeatured,
                ThumbnailImage = image != null ? image.ImagePath : "no-image.jpg"
            };
            return acccountViewModel;
        }

        public async Task<AccountImageViewModel> GetImageById(int imageId)
        {
            var image = await _context.AccountImages.FindAsync(imageId);
            if (image == null)
                throw new shopException($"Cannot find an image with id {imageId}");

            var viewModel = new AccountImageViewModel()
            {
                Caption = image.Caption,
                DateCreated = image.DateCreated,
                FileSize = image.FileSize,
                Id = image.Id,
                ImagePath = image.ImagePath,
                IsDefault = image.IsDefault,
                ProductId = image.AccountId,
                SortOrder = image.SortOrder
            };
            return viewModel;
        }

        public async Task<List<AccountImageViewModel>> GetListImages(int accountId)
        {
            return await _context.AccountImages.Where(x => x.AccountId == accountId)
                .Select(i => new AccountImageViewModel()
                {
                    Caption = i.Caption,
                    DateCreated = i.DateCreated,
                    FileSize = i.FileSize,
                    Id = i.Id,
                    ImagePath = i.ImagePath,
                    IsDefault = i.IsDefault,
                    ProductId = i.AccountId,
                    SortOrder = i.SortOrder
                }).ToListAsync();
        }

        public async Task<int> RemoveImage(int imageId)
        {
            var productImage = await _context.AccountImages.FindAsync(imageId);
            if (productImage == null)
                throw new shopException($"Cannot find an image with id {imageId}");
            _context.AccountImages.Remove(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(AccountUpdateRequest request)
        {
            var account = await _context.Accounts.FindAsync(request.Id);

            if (account == null) throw new shopException($"Cannot find a product with id: {request.Id}");
            if (request.Price < 0)
                throw new shopException($"Cannot Create product");
            account.Price = request.Price;
            account.Title = request.Title;
            account.Description = request.Description;
            account.Reincarnation = request.Reincarnation;
            account.Visional = request.Visional;
            account.UserNameAcc = request.UserNameAcc;
            account.PasswordAcc = request.PasswordAcc;
            account.IsFeatured = request.IsFeatured;

            //Save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.AccountImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.AccountId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.AccountImages.Update(thumbnailImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImage(int imageId, AccountImageUpdateRequest request)
        {
            var productImage = await _context.AccountImages.FindAsync(imageId);
            if (productImage == null)
                throw new shopException($"Cannot find an image with id {imageId}");

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.AccountImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int accountId, decimal newPrice)
        {
            var product = await _context.Accounts.FindAsync(accountId);
            if (product == null) throw new shopException($"Cannot find a product with id: {accountId}");
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }

        public async Task<PagedResult<AccountVm>> GetAllByCategoryId(GetPublicAccountPagingRequest request)
        {
            //1. Select join
            var query = from a in _context.Accounts
                        join aic in _context.AccountInCategories on a.Id equals aic.AccountId
                        join c in _context.Categories on aic.CategoryId equals c.Id
                        select new { a, aic };
            //2. filter
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(p => p.aic.CategoryId == request.CategoryId);
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new AccountVm()
                {
                    Id = x.a.Id,
                    Title = x.a.Title,
                    Price = x.a.Price,
                    DateCreated = x.a.DateCreated,
                    Description = x.a.Description,
                    Reincarnation = x.a.Reincarnation,
                    Visional = x.a.Visional,
                    UserNameAcc = x.a.UserNameAcc,
                    PasswordAcc = x.a.PasswordAcc,
                    ViewCount = x.a.ViewCount,
                    UserCreate = x.a.UserCreate
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AccountVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            var user = await _context.Accounts.FindAsync(id);
            if (user == null)
            {
                return new ApiErrorResult<bool>($"Sản phẩm với id {id} không tồn tại");
            }
            foreach (var category in request.Categories)
            {
                var productInCategory = await _context.AccountInCategories
                    .FirstOrDefaultAsync(x => x.CategoryId == int.Parse(category.Id)
                    && x.AccountId == id);
                if (productInCategory != null && category.Selected == false)
                {
                    _context.AccountInCategories.Remove(productInCategory);
                }
                else if (productInCategory == null && category.Selected)
                {
                    await _context.AccountInCategories.AddAsync(new AccountInCategory()
                    {
                        CategoryId = int.Parse(category.Id),
                        AccountId = id
                    });
                }
            }
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }

        public async Task<List<AccountVm>> GetFeaturedAccounts(int take)
        {
            //1. Select join
            var query = from a in _context.Accounts
                        join ai in _context.AccountImages on a.Id equals ai.AccountId into aai
                        from ai in aai.DefaultIfEmpty()
                        where (ai == null || ai.IsDefault == true && a.IsFeatured == true)
                        select new { a, ai };
            var data = await query.OrderByDescending(x => x.a.ViewCount).Take(take)
                .Select(x => new AccountVm()
                {
                    Id = x.a.Id,
                    Title = x.a.Title,
                    Price = x.a.Price,
                    DateCreated = x.a.DateCreated,
                    Description = x.a.Description,
                    Reincarnation = x.a.Reincarnation,
                    Visional = x.a.Visional,
                    ViewCount = x.a.ViewCount,
                    ThumbnailImage = x.ai.ImagePath,
                    IsFeatured = x.a.IsFeatured,
                    UserCreate = x.a.UserCreate
                }).ToListAsync();

            return data;
        }

        public async Task<List<AccountVm>> GetLatestAccounts(int take)
        {
            //1. Select join
            var query = from a in _context.Accounts
                        join ai in _context.AccountImages on a.Id equals ai.AccountId into aai
                        from ai in aai.DefaultIfEmpty()
                        where (ai == null || ai.IsDefault == true && a.IsFeatured == true)
                        select new { a, ai };

            var data = await query.OrderByDescending(x => x.a.DateCreated).Take(take)
                .Select(x => new AccountVm()
                {
                    Id = x.a.Id,
                    Title = x.a.Title,
                    Price = x.a.Price,
                    DateCreated = x.a.DateCreated,
                    Description = x.a.Description,
                    Reincarnation = x.a.Reincarnation,
                    Visional = x.a.Visional,
                    ViewCount = x.a.ViewCount,
                    ThumbnailImage = x.ai.ImagePath,
                    IsFeatured = x.a.IsFeatured,
                    UserCreate = x.a.UserCreate
                }).ToListAsync();

            return data;
        }
    }
}