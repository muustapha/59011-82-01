using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WpfDbPersonne.Models.Data;
using ConfigurationManager = System.Configuration.ConfigurationManager;
namespace WpfDbPersonne.Models;

public partial class PersonneDbContext : DbContext
{
    public PersonneDbContext()
    {
    }

    public PersonneDbContext(DbContextOptions<PersonneDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Personne> Personne { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;user=root;port=3306;database=personne;ssl mode=none");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personne>(entity =>
        {
            entity.HasKey(e => e.IdPersonne).HasName("PRIMARY");

            entity.ToTable("personnes");

            entity.HasIndex(e => e.Prenom, "prenom_id");

            entity.Property(e => e.IdPersonne)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(50)
                .HasColumnName("adresse");
            entity.Property(e => e.CodePostal)
                .HasColumnType("int(11)")
                .HasColumnName("codePostal");
            entity.Property(e => e.Nom)
                .HasMaxLength(45)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(20)
                .HasColumnName("prenom");
            entity.Property(e => e.Ville)
                .HasMaxLength(20)
                .HasColumnName("ville");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
