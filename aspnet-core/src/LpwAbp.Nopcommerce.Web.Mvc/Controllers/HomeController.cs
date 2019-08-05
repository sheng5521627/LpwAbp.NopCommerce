using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LpwAbp.Nopcommerce.Controllers;

namespace LpwAbp.Nopcommerce.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : NopcommerceControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
