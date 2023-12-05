using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using GestionCrudMvvm.Json;

namespace GestionCrudMvvm.Models.Services
{
    public partial class ProduitsDbContext : DbContext
    {
        private const string JsonPath = @"U:\59011-82-01\C#\gereCrudMvc\produits.json";

        public DbSet<Produit> Produits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ensure that the directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(JsonPath));

            // Load data from JSON file
            List<Produit> produits = DownloaderDonnees(JsonPath);
            if (produits != null)
            {
                Produits.AddRange(produits);
            }

            base.OnConfiguring(optionsBuilder);
        }


    }
}

