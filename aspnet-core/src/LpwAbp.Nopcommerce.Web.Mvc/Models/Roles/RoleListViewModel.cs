using System.Collections.Generic;
using LpwAbp.Nopcommerce.Roles.Dto;

namespace LpwAbp.Nopcommerce.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
