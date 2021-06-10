using shopAcc.ViewModels.Catalog.Categories;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<PagedResult<CategoryVm>> GetPagings(GetCategoryPagingRequest request);

        Task<List<CategoryVm>> GetAll();

        Task<CategoryVm> GetById(int id);

        Task<bool> CreateCategory(CategoryCreateRequest request);

        Task<bool> UpdateCategory(CategoryUpdateRequest request);

        Task<bool> DeleteCategory(int id);
    }
}