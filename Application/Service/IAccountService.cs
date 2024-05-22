using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;

namespace Application.Service
{
    public interface IAccountService
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUserWithClaimsAsync();
        Task SetupAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
        //Task SaveActivityAsync(ActivityTrackerRequestDTO model)
        //Task<IEnumerable<IGrouping<DateTime, ActivityTrackerResonseDTO>>> GroupActivity();
    }
}
