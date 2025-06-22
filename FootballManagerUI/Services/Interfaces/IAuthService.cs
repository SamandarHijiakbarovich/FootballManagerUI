using FootballManagerUI.Models;

namespace FootballManagerUI.Services.Interfaces
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(UserRegisterDto registerDto);
        Task<string?> LoginAsync(UserLoginDto loginDto);
        Task LogoutAsync();
    }
}
