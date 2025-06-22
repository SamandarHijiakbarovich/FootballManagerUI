using FootballManagerUI.Models;

namespace FootballManagerUI.Services.Interfaces
{
    public interface IMatchService
    {
        Task<List<MatchDto>> GetAllMatchesAsync();
        Task<MatchDto?> GetMatchByIdAsync(int id);
        Task<bool> CreateMatchAsync(CreateMatchDto match);
        Task<bool> UpdateMatchAsync(int id, UpdateMatchDto match);
        Task<bool> DeleteMatchAsync(int id);
    }
}
