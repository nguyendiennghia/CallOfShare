using System.Threading.Tasks;
using Abp.Application.Services;
using CallOfShare.Sessions.Dto;

namespace CallOfShare.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
