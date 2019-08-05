using System.Collections.Generic;
using System.Linq;
using LpwAbp.Nopcommerce.Roles.Dto;
using LpwAbp.Nopcommerce.Users.Dto;

namespace LpwAbp.Nopcommerce.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
