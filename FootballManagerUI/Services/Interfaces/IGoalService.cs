using FootballManagerUI.Models;

namespace FootballManagerUI.Services.Interfaces
{
    public interface IGoalService
    {
        Task<List<GoalDto>> GetAllGoalsAsync();
        Task<GoalDto?> GetGoalByIdAsync(int id);
        Task<bool> CreateGoalAsync(CreateGoalDto goal);
        Task<bool> UpdateGoalAsync(int id, UpdateGoalDto goal);
        Task<bool> DeleteGoalAsync(int id);
    }
}
