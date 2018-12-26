using System.Threading.Tasks;
using CallOfShare.Configuration.Dto;

namespace CallOfShare.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
