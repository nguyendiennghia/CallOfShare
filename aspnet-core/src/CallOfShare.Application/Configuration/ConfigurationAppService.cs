using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CallOfShare.Configuration.Dto;

namespace CallOfShare.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CallOfShareAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
