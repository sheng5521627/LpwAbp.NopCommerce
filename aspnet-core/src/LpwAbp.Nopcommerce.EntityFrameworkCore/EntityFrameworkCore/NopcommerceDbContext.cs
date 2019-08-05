using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LpwAbp.Nopcommerce.Authorization.Roles;
using LpwAbp.Nopcommerce.Authorization.Users;
using LpwAbp.Nopcommerce.MultiTenancy;

namespace LpwAbp.Nopcommerce.EntityFrameworkCore
{
    public class NopcommerceDbContext : AbpZeroDbContext<Tenant, Role, User, NopcommerceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NopcommerceDbContext(DbContextOptions<NopcommerceDbContext> options)
            : base(options)
        {
        }
    }
}
