using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CallOfShare.EntityFrameworkCore
{
    public static class CallOfShareDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CallOfShareDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CallOfShareDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
