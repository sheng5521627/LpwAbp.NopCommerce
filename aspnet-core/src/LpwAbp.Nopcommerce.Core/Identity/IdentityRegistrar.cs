using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using LpwAbp.Nopcommerce.Authorization;
using LpwAbp.Nopcommerce.Authorization.Roles;
using LpwAbp.Nopcommerce.Authorization.Users;
using LpwAbp.Nopcommerce.Editions;
using LpwAbp.Nopcommerce.MultiTenancy;

namespace LpwAbp.Nopcommerce.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
