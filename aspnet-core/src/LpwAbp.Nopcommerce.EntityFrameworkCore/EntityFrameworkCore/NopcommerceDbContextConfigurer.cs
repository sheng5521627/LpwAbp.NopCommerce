using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LpwAbp.Nopcommerce.EntityFrameworkCore
{
    public static class NopcommerceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NopcommerceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NopcommerceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
