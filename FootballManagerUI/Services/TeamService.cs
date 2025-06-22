using FootballManagerUI.Models;
using FootballManagerUI.Services.Interfaces;
using System.Net.Http.Json;

namespace FootballManagerUI.Services
{
    public class TeamService : ITeamService
    {
        private readonly HttpClient _httpClient;

        public TeamService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateTeamAsync(CreateTeamDto team)
        {
            var response = await _httpClient.PostAsJsonAsync("api/teams", team);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteTeamAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/teams/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<TeamDto>> GetAllTeamsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<TeamDto>>("api/teams") ?? new List<TeamDto>();
        }

        public async Task<TeamDto?> GetTeamByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<TeamDto>($"api/teams/{id}");
        }

        public async Task<bool> UpdateTeamAsync(int id, UpdateTeamDto team)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/teams/{id}", team);
            return response.IsSuccessStatusCode;
        }
    }
}
