using Microsoft.EntityFrameworkCore;

namespace ChristianGomezFinal.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext (DbContextOptions<GameDbContext> options)
            : base(options)
            {
            
            }
            public DbSet<Game> Games {get; set;}
            public DbSet<Character> Characters {get;set;}
    }
}