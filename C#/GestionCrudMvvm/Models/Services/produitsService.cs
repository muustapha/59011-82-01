using GestionCrudMvvm;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

public class ProduitsService
{
    private const string JsonPath = @"C:\Users\utilisateur\Desktop\GIT\Nouveau dossier\59011-82-01\C#\GestionCrudMvvmproduits.json";

    public List<Produit> GetAllProduits()
    {
        var jsonData = File.ReadAllText(JsonPath);
        return JsonConvert.DeserializeObject<List<Produit>>(jsonData);
    }

    public Produit GetProduitById(int id)
    {
        var produits = GetAllProduits();
        return produits.FirstOrDefault(p => p.IdProduit == id);
    }

    public void AddProduits(Produit p)
    {
        var produits = GetAllProduits();
        produits.Add(p);
        SaveProduits(produits);
    }

    public void UpdateProduit(Produit p)
    {
        var produits = GetAllProduits();
        var produitToUpdate = produits.FirstOrDefault(prod => prod.IdProduit == p.IdProduit);

        if (produitToUpdate != null)
        {
            // Mettre à jour les propriétés
            produitToUpdate.Nom = p.Nom;
            produitToUpdate.Prix = p.Prix;
            // Ajoutez ici les autres propriétés à mettre à jour

            SaveProduits(produits);
        }
        else
        {
            throw new ArgumentException("Produit non trouvé");
        }
    }

    public void DeleteProduit(Produit p)
    {
        var produits = GetAllProduits();
        produits.Remove(p);
        SaveProduits(produits);
    }

    private void SaveProduits(List<Produit> produits)
    {
        var jsonData = JsonConvert.SerializeObject(produits);
        File.WriteAllText(JsonPath, jsonData);
    }
}