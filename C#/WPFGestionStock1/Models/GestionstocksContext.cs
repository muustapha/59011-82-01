using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WPFGestionStock1.Models.Data;

namespace WPFGestionStock1.Models;

public partial class GestionstocksContext : DbContext
{
    public GestionstocksContext()
    {
    }

    public GestionstocksContext(DbContextOptions<GestionstocksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<TypesProduit> TypesProduits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;user=root;port=3306;database=gestionstocks;ssl mode=none");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.IdArticle).HasName("PRIMARY");

            entity.ToTable("articles");

            entity.HasIndex(e => e.IdCategorie, "IdCategories");

            entity.Property(e => e.IdArticle).HasColumnType("int(11)");
            entity.Property(e => e.IdCategorie).HasColumnType("int(11)");
            entity.Property(e => e.LibelleArticle)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.QuantiteStockee).HasColumnType("int(11)");

            entity.HasOne(d => d.Categorie).WithMany(p => p.Articles)
                .HasForeignKey(d => d.IdCategorie)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("articles_ibfk_1");
        });

        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.IdCategorie).HasName("PRIMARY");

            entity.ToTable("categories");

            entity.HasIndex(e => e.IdTypeProduit, "IdTypesProduits");

            entity.Property(e => e.IdCategorie).HasColumnType("int(11)");
            entity.Property(e => e.IdTypeProduit).HasColumnType("int(11)");
            entity.Property(e => e.LibelleCategorie).HasMaxLength(100);

            entity.HasOne(d => d.TypesProduit).WithMany(p => p.Categories)
                .HasForeignKey(d => d.IdTypeProduit)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("categories_ibfk_1");
        });

        modelBuilder.Entity<TypesProduit>(entity =>
        {
            entity.HasKey(e => e.IdTypesProduit).HasName("PRIMARY");

            entity.ToTable("TypesProduits");

            entity.Property(e => e.IdTypesProduit).HasColumnType("int(11)");
            entity.Property(e => e.LibelleTypeProduit).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
