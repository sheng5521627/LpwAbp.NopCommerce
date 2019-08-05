using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LpwAbp.Nopcommerce.Configuration;

namespace LpwAbp.Nopcommerce.Web.Host.Startup
{
    [DependsOn(
       typeof(NopcommerceWebCoreModule))]
    public class NopcommerceWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NopcommerceWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NopcommerceWebHostModule).GetAssembly());
        }
    }
}
