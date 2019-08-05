using Abp.AspNetCore.Mvc.ViewComponents;

namespace LpwAbp.Nopcommerce.Web.Views
{
    public abstract class NopcommerceViewComponent : AbpViewComponent
    {
        protected NopcommerceViewComponent()
        {
            LocalizationSourceName = NopcommerceConsts.LocalizationSourceName;
        }
    }
}
