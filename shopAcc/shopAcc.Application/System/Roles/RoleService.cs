using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shopAcc.Data.Entities;
using shopAcc.ViewModels.Common;
using shopAcc.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<ApiResult<bool>> Create(CreateRoleRequest request)
        {
            var idRole = await _roleManager.FindByNameAsync(request.Name);
            if (idRole != null)
            {
                return new ApiErrorResult<bool>("Quyền đã tồn tại");
            }
            idRole = new AppRole()
            {
                Name = request.Name,
                NormalizedName = request.NormalizedName,
                Description = request.Description,
            };
            var result = await _roleManager.CreateAsync(idRole);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Thêm quyền không thành công");
        }

        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles.Select(x => new RoleVm()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToListAsync();
            return roles;
        }
    }
}