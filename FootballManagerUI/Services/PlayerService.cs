using FootballManagerUI.Models;
using FootballManagerUI.Services.Interfaces;
using System.Net.Http.Json;

namespace FootballManagerUI.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly HttpClient _http;

        public PlayerService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<PlayerDto>> GetAllPlayersAsync()
        {
            return await _http.GetFromJsonAsync<List<PlayerDto>>("api/player") ?? new();
        }

        public async Task<PlayerDto?> GetPlayerByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<PlayerDto>($"api/player/{id}");
        }

        public async Task<bool> CreatePlayerAsync(CreatePlayerDto player)
        {
            var response = await _http.PostAsJsonAsync("api/player", player);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePlayerAsync(int id, UpdatePlayerDto player)
        {
            var response = await _http.PutAsJsonAsync($"api/player/{id}", player);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePlayerAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/player/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
