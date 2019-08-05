using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LpwAbp.Nopcommerce.Controllers;

namespace LpwAbp.Nopcommerce.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : NopcommerceControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
