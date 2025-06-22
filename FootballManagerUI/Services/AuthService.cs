using FootballManagerUI.Models;
using FootballManagerUI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Json;

namespace FootballManagerUI.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string?> LoginAsync(UserLoginDto loginDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginDto);
            if (response.IsSuccessStatusCode)
            {
                var tokenDto = await response.Content.ReadFromJsonAsync<TokenDto>();
                return tokenDto?.AccessToken;
            }
            return null;
        }

        public async Task LogoutAsync()
        {
            await _httpClient.PostAsync("api/auth/logout", null);
        }

        public async Task<bool> RegisterAsync(UserRegisterDto registerDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/auth/register", registerDto);
            return response.IsSuccessStatusCode;
        }
    }
}
