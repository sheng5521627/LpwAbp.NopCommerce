using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LpwAbp.Nopcommerce.MultiTenancy.Dto;

namespace LpwAbp.Nopcommerce.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

