using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LpwAbp.Nopcommerce.Configuration;
using LpwAbp.Nopcommerce.Web;

namespace LpwAbp.Nopcommerce.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NopcommerceDbContextFactory : IDesignTimeDbContextFactory<NopcommerceDbContext>
    {
        public NopcommerceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NopcommerceDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NopcommerceDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NopcommerceConsts.ConnectionStringName));

            return new NopcommerceDbContext(builder.Options);
        }
    }
}
