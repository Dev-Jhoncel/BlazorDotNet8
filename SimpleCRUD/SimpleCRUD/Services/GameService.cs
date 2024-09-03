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

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
