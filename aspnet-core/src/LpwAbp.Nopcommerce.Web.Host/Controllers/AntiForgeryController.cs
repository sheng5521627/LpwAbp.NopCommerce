using Microsoft.AspNetCore.Antiforgery;
using LpwAbp.Nopcommerce.Controllers;

namespace LpwAbp.Nopcommerce.Web.Host.Controllers
{
    public class AntiForgeryController : NopcommerceControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
