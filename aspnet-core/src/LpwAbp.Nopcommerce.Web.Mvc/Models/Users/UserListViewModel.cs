using System.Collections.Generic;
using LpwAbp.Nopcommerce.Roles.Dto;
using LpwAbp.Nopcommerce.Users.Dto;

namespace LpwAbp.Nopcommerce.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
