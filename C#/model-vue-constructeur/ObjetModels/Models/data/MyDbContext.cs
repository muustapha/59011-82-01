using Microsoft.EntityFrameworkCore;

namespace ObjetModels.Models.data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            
        }
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {

        }

        public DbSet<Personnes> Personnes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Personnes>(e => e.Property(o =>
            o.Age).HasColumnType("tinyint").HasConversion<short>());
        }
    }


}
