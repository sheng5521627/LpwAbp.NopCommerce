using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LpwAbp.Nopcommerce.Roles.Dto;

namespace LpwAbp.Nopcommerce.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);

        Task<ListResultDto<RoleListDto>> GetRolesAsync(GetRolesInput input);
    }
}
