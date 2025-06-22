using FootballManagerUI.Models;

namespace FootballManagerUI.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<List<PlayerDto>> GetAllPlayersAsync();
        Task<PlayerDto?> GetPlayerByIdAsync(int id);
        Task<bool> CreatePlayerAsync(CreatePlayerDto player);
        Task<bool> UpdatePlayerAsync(int id, UpdatePlayerDto player);
        Task<bool> DeletePlayerAsync(int id);
    }
}
