using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LpwAbp.Nopcommerce.Roles.Dto;
using LpwAbp.Nopcommerce.Users.Dto;

namespace LpwAbp.Nopcommerce.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
