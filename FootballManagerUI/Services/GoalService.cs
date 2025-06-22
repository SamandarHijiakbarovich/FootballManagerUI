using FootballManagerUI.Models;
using FootballManagerUI.Services.Interfaces;
using System.Net.Http.Json;

namespace FootballManagerUI.Services
{
    public class GoalService : IGoalService
    {
        private readonly HttpClient _httpClient;

        public GoalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateGoalAsync(CreateGoalDto goal)
        {
            var response = await _httpClient.PostAsJsonAsync("api/goals", goal);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteGoalAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/goals/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<GoalDto>> GetAllGoalsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<GoalDto>>("api/goals") ?? new List<GoalDto>();
        }

        public async Task<GoalDto?> GetGoalByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<GoalDto>($"api/goals/{id}");
        }

        public async Task<bool> UpdateGoalAsync(int id, UpdateGoalDto goal)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/goals/{id}", goal);
            return response.IsSuccessStatusCode;
        }
    }
}
