using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CallOfShare.MultiTenancy.Dto;

namespace CallOfShare.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

