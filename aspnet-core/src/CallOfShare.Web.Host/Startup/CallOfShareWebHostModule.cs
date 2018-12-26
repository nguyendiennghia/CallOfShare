using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CallOfShare.Configuration;

namespace CallOfShare.Web.Host.Startup
{
    [DependsOn(
       typeof(CallOfShareWebCoreModule))]
    public class CallOfShareWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CallOfShareWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CallOfShareWebHostModule).GetAssembly());
        }
    }
}
