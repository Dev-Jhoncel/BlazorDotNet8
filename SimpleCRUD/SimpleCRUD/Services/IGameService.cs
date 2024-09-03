using SimpleCRUD.Entity;

namespace SimpleCRUD.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}
