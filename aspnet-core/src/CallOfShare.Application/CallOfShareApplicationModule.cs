using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CallOfShare.Authorization;

namespace CallOfShare
{
    [DependsOn(
        typeof(CallOfShareCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CallOfShareApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CallOfShareAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CallOfShareApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
