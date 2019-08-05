using Abp.AutoMapper;
using LpwAbp.Nopcommerce.Sessions.Dto;

namespace LpwAbp.Nopcommerce.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
