using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using GestionCrudMvvm.Json;

namespace GestionCrudMvvm.Models
{
    public partial class ProduitsDbContext : DbContext
    {

        private List<Produit> ChargerDonnees(string jsonPath)
        {
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                return JsonConvert.DeserializeObject<List<Produit>>(json);
            }

            return new List<Produit>();
        }

        private const string JsonPath = @"C:\Users\utilisateur\Desktop\GIT\Nouveau dossier\59011-82-01\C#\GestionCrudMvvmproduits.json";

        public DbSet<Produit> Produits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ensure that the directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(JsonPath));

            // Load data from JSON file
            List<Produit> produits = ChargerDonnees(JsonPath);
            if (produits != null)
            {
                Produits.AddRange(produits);
            }

            base.OnConfiguring(optionsBuilder);
        }


    }
}

