using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using LpwAbp.Nopcommerce.Authorization.Users;
using LpwAbp.Nopcommerce.Editions;

namespace LpwAbp.Nopcommerce.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
