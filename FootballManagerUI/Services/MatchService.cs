using FootballManagerUI.Models;
using FootballManagerUI.Services.Interfaces;
using System.Net.Http.Json;

namespace FootballManagerUI.Services
{
    public class MatchService : IMatchService
    {
        private readonly HttpClient _httpClient;

        public MatchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateMatchAsync(CreateMatchDto match)
        {
            var response = await _httpClient.PostAsJsonAsync("api/matches", match);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteMatchAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/matches/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<MatchDto>> GetAllMatchesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<MatchDto>>("api/matches") ?? new List<MatchDto>();
        }

        public async Task<MatchDto?> GetMatchByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<MatchDto>($"api/matches/{id}");
        }

        public async Task<bool> UpdateMatchAsync(int id, UpdateMatchDto match)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/matches/{id}", match);
            return response.IsSuccessStatusCode;
        }
    }
}
