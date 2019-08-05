using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LpwAbp.Nopcommerce.Authorization;

namespace LpwAbp.Nopcommerce
{
    [DependsOn(
        typeof(NopcommerceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NopcommerceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NopcommerceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NopcommerceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
