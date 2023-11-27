using Microsoft.EntityFrameworkCore;

namespace API1.Models.data
{
    public class MyFootballDbContext : DbContext
    {
        public MyFootballDbContext(DbContextOptions<MyFootballDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Joueur> Joueurs { get; set; }
        public virtual DbSet<Arbitre> Arbitres { get; set; }
    }
}