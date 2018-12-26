using Abp.Authorization;
using CallOfShare.Authorization.Roles;
using CallOfShare.Authorization.Users;

namespace CallOfShare.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
