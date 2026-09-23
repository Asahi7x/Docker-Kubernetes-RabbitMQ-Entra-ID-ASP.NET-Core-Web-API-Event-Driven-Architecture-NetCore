using eCommerce.Core.DTOs;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _usersRepository;

        public UserService(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<AuthenticationResponseDto?> Login(LoginRequestDto loginRequestDto)
        {
            ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassword(loginRequestDto.Email!, loginRequestDto.Password!);

            if (user == null)
            {
                return null;
            }

            return new AuthenticationResponseDto(user.UserID, user.Email, user.PersonName, user.Gender, "Token", Success: true);
        }

        public async Task<AuthenticationResponseDto?> Register(RegisterRequestDto registerRequestDto)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Email = registerRequestDto.Email,
                Password = registerRequestDto.Password,
                PersonName = registerRequestDto.PersonName,
                Gender = registerRequestDto.Gender.ToString()
            };

            ApplicationUser? registeredUser = await _usersRepository.AddUser(user);

            if (registeredUser == null)
            {
                return null;
            }

            return new AuthenticationResponseDto(registeredUser.UserID, registeredUser.Email, registeredUser.PersonName, registeredUser.Gender, "Token", Success: true);
        }
    }
}
