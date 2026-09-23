using eCommerce.Core.DTOs;

namespace eCommerce.Core.ServiceContracts
{
    public interface IUserService
    {
        Task<AuthenticationResponseDto?> Login(LoginRequestDto loginRequestDto);
        Task<AuthenticationResponseDto?> Register(RegisterRequestDto registerRequestDto);
    }
}
