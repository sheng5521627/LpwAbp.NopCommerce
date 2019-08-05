using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace LpwAbp.Nopcommerce.Web.Views
{
    public abstract class NopcommerceRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected NopcommerceRazorPage()
        {
            LocalizationSourceName = NopcommerceConsts.LocalizationSourceName;
        }
    }
}
