using Abp.MultiTenancy;
using LpwAbp.Nopcommerce.Authorization.Users;

namespace LpwAbp.Nopcommerce.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
