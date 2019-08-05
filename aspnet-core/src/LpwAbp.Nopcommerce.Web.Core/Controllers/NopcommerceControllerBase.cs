using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LpwAbp.Nopcommerce.Controllers
{
    public abstract class NopcommerceControllerBase: AbpController
    {
        protected NopcommerceControllerBase()
        {
            LocalizationSourceName = NopcommerceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
