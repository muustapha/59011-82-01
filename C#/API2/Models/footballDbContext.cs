using System;
using System.Collections.Generic;
using API2.Models.data;
using Microsoft.EntityFrameworkCore;
using testRecupTable1.Models.data;

namespace API2.Models;

public partial class footballDbContext : DbContext
{
    public footballDbContext()
    {
    }

    public footballDbContext(DbContextOptions<footballDbContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Equipe> Equipes { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    public virtual DbSet<Arbitre> Arbitres { get; set; }

    public virtual DbSet<Partita> Partita { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("name=default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.Entity<Equipe>(entity =>
        {
            entity.HasKey(e => e.IdEquipe).HasName("PRIMARY");

            entity.ToTable("equipes");

            entity.Property(e => e.IdEquipe).HasColumnType("int(11)");
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
                .HasColumnType("int(5)")
                .HasColumnName("idJoueur");
            entity.Property(e => e.Age).HasColumnType("int(50)");
            entity.Property(e => e.Nationalite)
                .HasMaxLength(50)
                .HasColumnName("nationalite");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Poste).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.HasKey(e => e.IdRelation).HasName("PRIMARY");

            entity.ToTable("relation");

            entity.Property(e => e.IdRelation).HasColumnType("int(11)");
            entity.Property(e => e.DateDebutContract).HasMaxLength(6);
            entity.Property(e => e.IdEquipe).HasColumnType("int(11)");
            entity.Property(e => e.IdJoueur).HasColumnType("int(11)");
            entity.Property(e => e.NumeroDeMaillot).HasColumnType("int(11)");
            entity.Property(e => e.Salaire).HasColumnType("int(100)");
        });
        modelBuilder.Entity<Partita>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partita");

            entity.Property(e => e.Date).HasMaxLength(6);
            entity.Property(e => e.IdPartita).HasColumnType("int(5)");
            entity.Property(e => e.Ligue)
                .HasMaxLength(50)
                .HasColumnName("ligue");
        });

        modelBuilder.Entity<Arbitre>(entity =>
        {
            entity.HasKey(e => e.IdArbitre).HasName("PRIMARY");

            entity.ToTable("arbitres");

            entity.Property(e => e.IdArbitre)
                .HasColumnType("int(5)")
                .HasColumnName("idArbitre");
            entity.Property(e => e.Age).HasColumnType("int(5)");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Poste).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
