using GestionCrudMvvm;
using System.Collections.Generic;
using GestionCrudMvvm.Models.Profiles;
using GestionCrudMvvm.Json;

public class ProduitsService
{
        static public string Path { get; set; } = "../../../Produit.json";
        static public int NextId { get; set; }

        public static List<Produit> GetAllProduits()
        {
            StructureJson sj = DaoJson.LireFichier(Path);
            List<Produit> liste = Profiles.FromObjectToProduits(sj.Liste);
            NextId = sj.NextId;

            return liste;
        }

        // methode qui met à jour le fichier avec les produits 
        static public void SaveProduit(List<Produit> liste)
        {
            StructureJson sj = new StructureJson();
            sj.Liste = Profiles.FromProduitsToObject(liste);
            sj.NextId = NextId;
            DaoJson.EcrireFichier(sj, Path); //enregistrer fichier
        }

        static public Produit GetById(int idProduit)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produit> liste = GetAllProduits();
            // on recherche la position du produit dans la liste
            Produit p = liste.Find(r => r.IdProduit == idProduit);
            return p;
        }

        static public void AddProduit(Produit p)
        //Méthode qui permet d'entrer un enregistrement
        {
            List<Produit> liste = GetAllProduits();
            p.IdProduit = NextId++;
            // on ajoute l'enregistrement
            liste.Add(p);
            SaveProduit(liste);
        }
        static public void UpdateProduit(Produit p)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produit> liste = GetAllProduits();
            // on recherche la position du produit dans la liste
            int position = liste.FindIndex(r => r.IdProduit == p.IdProduit);
            // on met à jour le produit dans la liste
            liste[position].IdProduit = p.IdProduit;
            liste[position].Nom = p.Nom; 
            liste[position].Prix = p.Prix; 
            liste[position].CoutProduction = p.CoutProduction;
            liste[position].Quantite = p.Quantite;
            liste[position].LieuxProduction = p.LieuxProduction;
            
            // on sauvegarde dans le fichier
            SaveProduit(liste);
        }
        static public void DeleteProduit(Produit p)
        //Méthode qui permet de modifier un enregistrement
        {
            List<Produit> liste = GetAllProduits();
            // on recherche la position du produit dans la liste
            liste.RemoveAll(x => x.IdProduit == p.IdProduit);
            // on sauvegarde dans le fichier
            SaveProduit(liste);
        }
    }

