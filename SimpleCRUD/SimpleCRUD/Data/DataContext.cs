using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using SimpleCRUD.Entity;

namespace SimpleCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}
