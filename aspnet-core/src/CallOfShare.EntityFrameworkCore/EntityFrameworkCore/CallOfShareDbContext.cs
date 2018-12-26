using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CallOfShare.Authorization.Roles;
using CallOfShare.Authorization.Users;
using CallOfShare.MultiTenancy;

namespace CallOfShare.EntityFrameworkCore
{
    public class CallOfShareDbContext : AbpZeroDbContext<Tenant, Role, User, CallOfShareDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CallOfShareDbContext(DbContextOptions<CallOfShareDbContext> options)
            : base(options)
        {
        }
    }
}
