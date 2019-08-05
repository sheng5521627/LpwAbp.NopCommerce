using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LpwAbp.Nopcommerce.MultiTenancy;

namespace LpwAbp.Nopcommerce.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
