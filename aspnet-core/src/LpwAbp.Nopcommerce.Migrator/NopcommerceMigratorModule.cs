using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LpwAbp.Nopcommerce.Configuration;
using LpwAbp.Nopcommerce.EntityFrameworkCore;
using LpwAbp.Nopcommerce.Migrator.DependencyInjection;

namespace LpwAbp.Nopcommerce.Migrator
{
    [DependsOn(typeof(NopcommerceEntityFrameworkModule))]
    public class NopcommerceMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public NopcommerceMigratorModule(NopcommerceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(NopcommerceMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                NopcommerceConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NopcommerceMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
