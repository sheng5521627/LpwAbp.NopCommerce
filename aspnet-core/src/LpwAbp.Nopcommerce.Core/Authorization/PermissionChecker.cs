using Abp.Authorization;
using LpwAbp.Nopcommerce.Authorization.Roles;
using LpwAbp.Nopcommerce.Authorization.Users;

namespace LpwAbp.Nopcommerce.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
