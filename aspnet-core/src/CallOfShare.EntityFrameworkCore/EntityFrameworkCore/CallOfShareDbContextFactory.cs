using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CallOfShare.Configuration;
using CallOfShare.Web;

namespace CallOfShare.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CallOfShareDbContextFactory : IDesignTimeDbContextFactory<CallOfShareDbContext>
    {
        public CallOfShareDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CallOfShareDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CallOfShareDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CallOfShareConsts.ConnectionStringName));

            return new CallOfShareDbContext(builder.Options);
        }
    }
}
