using Microsoft.EntityFrameworkCore;

namespace API1.Models.Data
{
    public partial class MyFootballDbContext : DbContext
    {
        public MyFootballDbContext(DbContextOptions<MyFootballDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Joueur> Joueurs { get; set; }
        public virtual DbSet<Arbitre> Arbitres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseMySQL("name=default");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Joueur>(entity =>
            {
                entity.HasKey(e => e.IdJoueur).HasName("PRIMARY");

                entity.ToTable("Joueurs");

                entity.Property(e => e.IdJoueur)
                    .HasColumnType("int(11)")
                    .HasColumnName("idJoueur");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .HasColumnName("nom");
                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .HasColumnName("prenom");
                entity.Property(e => e.Age)
                    .HasColumnType("int(11)")
                    .HasColumnName("Age");
                entity.Property(e => e.Poste)
                    .HasMaxLength(50)
                    .HasColumnName("poste");
                entity.Property(e => e.Nationalite)
                    .HasMaxLength(50)
                    .HasColumnName("nationalite");
           });
            modelBuilder.Entity<Arbitre>(entity =>
            {
                entity.HasKey(e => e.IdArbitre).HasName("PRIMARY");

                entity.ToTable("Arbitres");

                entity.Property(e => e.IdArbitre)
                    .HasColumnType("int(11)")
                    .HasColumnName("idArbitre");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .HasColumnName("nom");
                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .HasColumnName("prenom");
                entity.Property(e => e.Age)
                    .HasColumnType("int(11)")
                    .HasColumnName("Age");
                entity.Property(e => e.Poste)
                    .HasMaxLength(50)
                    .HasColumnName("poste");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}