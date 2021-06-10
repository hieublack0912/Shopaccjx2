using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopAcc.ViewModels.Catalog.Categories;
using shopAcc.Data.EF;
using shopAcc.Data.Entities;
using shopAcc.Data.Enums;
using shopAcc.ViewModels.Common;
using shopAcc.Utilities.Exceptions;

namespace shopAcc.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly EShopDbContext _context;

        public CategoryService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryVm>> GetAll()
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId
            }).ToListAsync();
        }

        public async Task<PagedResult<CategoryVm>> GetAllPaging(GetCategoryPagingRequest request)
        {
            //1. Select join
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        select new { c, ct };
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.ct.Name.Contains(request.Keyword));

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new CategoryVm()
                {
                    Id = x.c.Id,
                    Name = x.ct.Name,
                    SeoDescription = x.ct.SeoDescription,
                    ParentId = x.c.ParentId
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<CategoryVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<CategoryVm> GetById(int id)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where c.Id == id
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                SeoDescription = x.ct.SeoDescription,
                SeoTitle = x.ct.SeoTitle,
                SeoAlias = x.ct.SeoAlias,
                SortOrder = x.c.SortOrder,
                IsShowOnHome = x.c.IsShowOnHome,
                Status = x.c.Status,
                ParentId = x.c.ParentId
            }).FirstOrDefaultAsync();
        }

        public async Task<int> Create(CategoryCreateRequest request)
        {
            var translations = new List<CategoryTranslation>();

            translations.Add(new CategoryTranslation()
            {
                Name = request.Name,
                SeoDescription = request.SeoDescription,
                SeoAlias = request.SeoAlias,
                SeoTitle = request.SeoTitle,
            });
            var category = new Category()
            {
                SortOrder = request.SortOrder,
                IsShowOnHome = request.IsShowOnHome,
                ParentId = request.ParentId,
                Status = Status.Active,
                CategoryTranslations = translations
            };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }

        public async Task<int> Delete(int CategoryId)
        {
            var category = await _context.Categories.FindAsync(CategoryId);
            if (category == null) throw new shopException($"Cannot find a product: {CategoryId}");

            _context.Categories.Remove(category);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            var categoryTranslations = await _context.CategoryTranslations.FirstOrDefaultAsync(x => x.CategoryId == request.Id);

            if (category == null || categoryTranslations == null) throw new shopException($"Cannot find a category with id: {request.Id}");

            categoryTranslations.Name = request.Name;
            categoryTranslations.SeoDescription = request.SeoDescription;
            categoryTranslations.SeoTitle = request.SeoTitle;
            categoryTranslations.SeoAlias = request.SeoAlias;
            category.SortOrder = request.SortOrder;
            category.IsShowOnHome = request.IsShowOnHome;
            category.Status = request.Status;
            category.ParentId = request.ParentId;

            return await _context.SaveChangesAsync();
        }
    }
}