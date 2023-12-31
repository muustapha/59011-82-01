﻿using System;
using System.Collections.Generic;
using APIfootball.Models.data;
using Microsoft.EntityFrameworkCore;

namespace APIfootball.Models;

public partial class footbalDbContext : DbContext
{
    public footbalDbContext()
    {
    }

    public footbalDbContext(DbContextOptions<footbalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arbitre> Arbitres { get; set; }

    public virtual DbSet<Arbitrespartitum> Arbitrespartita { get; set; }

    public virtual DbSet<Equipe> Equipes { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Partitum> Partita { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("name=Default");

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

            entity.HasIndex(e => e.IdPartita, "IdPartita");

            entity.Property(e => e.IdEquipe).HasColumnType("int(11)");
            entity.Property(e => e.IdPartita).HasColumnType("int(11)");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Pays).HasMaxLength(50);
            entity.Property(e => e.SiteWeb)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.StadePrincipal).HasMaxLength(50);
            entity.Property(e => e.Ville).HasMaxLength(50);

            entity.HasOne(d => d.IdPartitaNavigation).WithMany(p => p.Equipes)
                .HasForeignKey(d => d.IdPartita)
                .HasConstraintName("equipes_ibfk_1");
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
