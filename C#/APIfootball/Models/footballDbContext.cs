using Microsoft.EntityFrameworkCore;

namespace APIfootball.Models
{
    public partial class footballDbContext : DbContext
    {
        public footballDbContext()
        {
        }

        public footballDbContext(DbContextOptions<footballDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arbitre> Arbitres { get; set; }

        public virtual DbSet<Equipe> Equipes { get; set; }

        public virtual DbSet<Joueur> Joueurs { get; set; }

        public virtual DbSet<Partita> Partita { get; set; }

        public virtual DbSet<Relation> Relations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL("name=default");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arbitre>(entity =>
            {
                entity.HasKey(e => e.IdArbitre).HasName("PRIMARY");

                entity.ToTable("arbitres");

                entity.Property(e => e.IdArbitre)
                    .HasColumnType("int(11)")
                    .HasColumnName("idArbitre");
                entity.Property(e => e.Age).HasColumnType("int(11)");
                entity.Property(e => e.IdPartita).HasColumnType("int(11)");
                entity.Property(e => e.Nom).HasMaxLength(50);
                entity.Property(e => e.Poste).HasMaxLength(50);
                entity.Property(e => e.Prenom).HasMaxLength(50);
            });

            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.HasKey(e => e.IdEquipe).HasName("PRIMARY");

                entity.ToTable("equipes");

                entity.Property(e => e.IdEquipe).HasColumnType("int(11)");
                entity.Property(e => e.IdPartita).HasColumnType("int(11)");
                entity.Property(e => e.Nom).HasMaxLength(50);
                entity.Property(e => e.Pays).HasMaxLength(50);
                entity.Property(e => e.SiteWeb)
                    .HasMaxLength(50)
                    .IsFixedLength();
                entity.Property(e => e.StadePrincipal).HasMaxLength(50);
                entity.Property(e => e.Ville).HasMaxLength(50);
            });

            modelBuilder.Entity<Joueur>(entity =>
            {
                entity.HasKey(e => e.IdJoueur).HasName("PRIMARY");

                entity.ToTable("joueurs");

                entity.Property(e => e.IdJoueur)
                    .HasColumnType("int(11)")
                    .HasColumnName("idJoueur");
                entity.Property(e => e.Age).HasColumnType("int(11)");
                entity.Property(e => e.Nationalite)
                    .HasMaxLength(50)
                    .HasColumnName("nationalite");
                entity.Property(e => e.Nom).HasMaxLength(50);
                entity.Property(e => e.Poste).HasMaxLength(50);
                entity.Property(e => e.Prenom).HasMaxLength(50);
            });

            modelBuilder.Entity<Partita>(entity =>
            {
                entity.HasKey(e => e.IdPartita).HasName("PRIMARY");

                entity.ToTable("partita");

                entity.Property(e => e.IdPartita).HasColumnType("int(11)");
                entity.Property(e => e.DateHeure).HasMaxLength(6);
                entity.Property(e => e.Ligue)
                    .HasMaxLength(50)
                    .HasColumnName("score");
                entity.Property(e => e.Score)
                .HasMaxLength(50)
                    .HasColumnName("score");
    
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.HasKey(e => e.IdRelation).HasName("PRIMARY");

                entity.ToTable("relation");

                entity.Property(e => e.IdRelation).HasColumnType("int(11)");
                entity.Property(e => e.DateDebutContract).HasColumnType("date");
                entity.Property(e => e.IdEquipe).HasColumnType("int(11)");
                entity.Property(e => e.IdJoueur).HasColumnType("int(11)");
                entity.Property(e => e.NumeroDeMaillot).HasColumnType("int(11)");
                entity.Property(e => e.Salaire).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
