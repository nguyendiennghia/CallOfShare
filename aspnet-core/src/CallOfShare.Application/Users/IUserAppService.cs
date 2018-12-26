using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CallOfShare.Roles.Dto;
using CallOfShare.Users.Dto;

namespace CallOfShare.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
