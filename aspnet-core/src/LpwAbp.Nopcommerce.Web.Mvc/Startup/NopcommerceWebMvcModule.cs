using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LpwAbp.Nopcommerce.Configuration;

namespace LpwAbp.Nopcommerce.Web.Startup
{
    [DependsOn(typeof(NopcommerceWebCoreModule))]
    public class NopcommerceWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NopcommerceWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<NopcommerceNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NopcommerceWebMvcModule).GetAssembly());
        }
    }
}
