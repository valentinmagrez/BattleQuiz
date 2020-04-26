using Microsoft.EntityFrameworkCore;

namespace Battleship.Server.Models
{
    public class BattleshipDbContext : DbContext
    {
        public BattleshipDbContext()
        {}
        public BattleshipDbContext(DbContextOptions<BattleshipDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }
    }
}
