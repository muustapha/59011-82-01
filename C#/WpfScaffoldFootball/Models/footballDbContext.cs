using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WpfScaffoldFootball.Models.Data;

namespace WpfScaffoldFootball.Models;

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

    public virtual DbSet<Arbitrespartitum> Arbitrespartita { get; set; }

    public virtual DbSet<Equipe> Equipes { get; set; }

    public virtual DbSet<Equipespartitum> Equipespartita { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Partitum> Partita { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;user=root;port=3306;database=footballdb;ssl mode=none");

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
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Poste).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
        });

        modelBuilder.Entity<Arbitrespartitum>(entity =>
        {
            entity.HasKey(e => e.IdArbitresPartita).HasName("PRIMARY");

            entity.ToTable("arbitrespartita");

            entity.HasIndex(e => e.IdArbitres, "idArbitre");

            entity.HasIndex(e => e.IdPartita, "idPartita");

            entity.Property(e => e.IdArbitresPartita)
                .HasColumnType("int(11)")
                .HasColumnName("idArbitresPartita");
            entity.Property(e => e.IdArbitres)
                .HasColumnType("int(11)")
                .HasColumnName("idArbitres");
            entity.Property(e => e.IdPartita)
                .HasColumnType("int(11)")
                .HasColumnName("idPartita");

            entity.HasOne(d => d.IdArbitresNavigation).WithMany(p => p.Arbitrespartita)
                .HasForeignKey(d => d.IdArbitres)
                .HasConstraintName("fk_arbitre_partita_arbitre");

            entity.HasOne(d => d.IdPartitaNavigation).WithMany(p => p.Arbitrespartita)
                .HasForeignKey(d => d.IdPartita)
                .HasConstraintName("fk_arbitre_partita_partita");
        });

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

        modelBuilder.Entity<Equipespartitum>(entity =>
        {
            entity.HasKey(e => e.IdEquipesPartita).HasName("PRIMARY");

            entity.ToTable("equipespartita");

            entity.HasIndex(e => e.IdEquipe, "idEquipes");

            entity.HasIndex(e => e.IdPartita, "idPartita");

            entity.Property(e => e.IdEquipesPartita)
                .HasColumnType("int(11)")
                .HasColumnName("idEquipesPartita");
            entity.Property(e => e.IdEquipe)
                .HasColumnType("int(11)")
                .HasColumnName("idEquipe");
            entity.Property(e => e.IdPartita)
                .HasColumnType("int(11)")
                .HasColumnName("idPartita");

            entity.HasOne(d => d.IdEquipeNavigation).WithMany(p => p.Equipespartita)
                .HasForeignKey(d => d.IdEquipe)
                .HasConstraintName("fk_Equipe_partita_Equipe");

            entity.HasOne(d => d.IdPartitaNavigation).WithMany(p => p.Equipespartita)
                .HasForeignKey(d => d.IdPartita)
                .HasConstraintName("fk_Equipe_partita_partita");
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

        modelBuilder.Entity<Partitum>(entity =>
        {
            entity.HasKey(e => e.IdPartita).HasName("PRIMARY");

            entity.ToTable("partita");

            entity.Property(e => e.IdPartita).HasColumnType("int(11)");
            entity.Property(e => e.DateHeure).HasMaxLength(6);
            entity.Property(e => e.Ligue)
                .HasMaxLength(50)
                .HasColumnName("ligue");
            entity.Property(e => e.Score).HasMaxLength(50);
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.HasKey(e => e.IdRelation).HasName("PRIMARY");

            entity.ToTable("relation");

            entity.HasIndex(e => new { e.IdEquipe, e.IdJoueur }, "IdEquipe");

            entity.HasIndex(e => e.IdJoueur, "IdJoueur");

            entity.Property(e => e.IdRelation).HasColumnType("int(11)");
            entity.Property(e => e.DateDebutContract).HasColumnType("date");
            entity.Property(e => e.IdEquipe).HasColumnType("int(11)");
            entity.Property(e => e.IdJoueur).HasColumnType("int(11)");
            entity.Property(e => e.NumeroDeMaillot).HasColumnType("int(11)");
            entity.Property(e => e.Salaire).HasColumnType("int(11)");

            entity.HasOne(d => d.IdEquipeNavigation).WithMany(p => p.Relations)
                .HasForeignKey(d => d.IdEquipe)
                .HasConstraintName("relation_ibfk_2");

            entity.HasOne(d => d.IdJoueurNavigation).WithMany(p => p.Relations)
                .HasForeignKey(d => d.IdJoueur)
                .HasConstraintName("relation_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
