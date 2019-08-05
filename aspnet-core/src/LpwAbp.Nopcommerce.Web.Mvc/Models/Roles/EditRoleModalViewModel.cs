using Abp.AutoMapper;
using LpwAbp.Nopcommerce.Roles.Dto;
using LpwAbp.Nopcommerce.Web.Models.Common;

namespace LpwAbp.Nopcommerce.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public EditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }

        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
