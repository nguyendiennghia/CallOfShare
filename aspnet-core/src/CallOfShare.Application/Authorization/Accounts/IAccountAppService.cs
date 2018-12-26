using System.Threading.Tasks;
using Abp.Application.Services;
using CallOfShare.Authorization.Accounts.Dto;

namespace CallOfShare.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
