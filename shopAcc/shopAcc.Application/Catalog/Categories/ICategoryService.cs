using shopAcc.ViewModels.Catalog.Categories;
using shopAcc.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll();

        Task<PagedResult<CategoryVm>> GetAllPaging(GetCategoryPagingRequest request);

        Task<CategoryVm> GetById(int id);

        Task<int> Create(CategoryCreateRequest request);

        Task<int> Delete(int CategoryId);

        Task<int> Update(CategoryUpdateRequest request);
    }
}