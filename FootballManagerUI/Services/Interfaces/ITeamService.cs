using FootballManagerUI.Models;

namespace FootballManagerUI.Services.Interfaces
{
    public interface ITeamService
    {
        Task<List<TeamDto>> GetAllTeamsAsync();
        Task<TeamDto?> GetTeamByIdAsync(int id);
        Task<bool> CreateTeamAsync(CreateTeamDto team);
        Task<bool> UpdateTeamAsync(int id, UpdateTeamDto team);
        Task<bool> DeleteTeamAsync(int id);
    }
}
