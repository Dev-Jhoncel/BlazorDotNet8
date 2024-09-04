using Microsoft.EntityFrameworkCore;
using SimpleCRUD.Data;
using SimpleCRUD.Entity;

namespace SimpleCRUD.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(1000);
            var games = await _context.Games.ToListAsync();
            return games;
        }
    }
}
