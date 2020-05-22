using Microsoft.EntityFrameworkCore;

namespace BattleQuiz.Server.Models
{
    public class BattleQuizDbContext : DbContext
    {
        public BattleQuizDbContext()
        {}
        public BattleQuizDbContext(DbContextOptions<BattleQuizDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }
    }
}
