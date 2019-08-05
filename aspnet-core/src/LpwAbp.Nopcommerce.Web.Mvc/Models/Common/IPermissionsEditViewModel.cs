using System.Collections.Generic;
using LpwAbp.Nopcommerce.Roles.Dto;

namespace LpwAbp.Nopcommerce.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}