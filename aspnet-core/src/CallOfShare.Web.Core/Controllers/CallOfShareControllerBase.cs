using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CallOfShare.Controllers
{
    public abstract class CallOfShareControllerBase: AbpController
    {
        protected CallOfShareControllerBase()
        {
            LocalizationSourceName = CallOfShareConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
