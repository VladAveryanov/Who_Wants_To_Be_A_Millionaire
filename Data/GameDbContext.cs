using Microsoft.EntityFrameworkCore;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data
{
    public class GameDbContext: DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {
            
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

    }
}
