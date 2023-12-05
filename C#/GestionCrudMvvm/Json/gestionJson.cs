using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GestionCrudMvvm.Json
{
    class gestionJson
    {
        public void UploaderDonnees(List<Produit> produits, string cheminFichier)
        {
            try
            {
                string json = JsonConvert.SerializeObject(produits, Formatting.Indented);
                File.WriteAllText(cheminFichier, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite lors de l'écriture du fichier JSON : " + ex.Message);
            }
        }

        public List<Produit> DownloaderDonnees(string cheminFichier)
        {
            try
            {
                string json = File.ReadAllText(cheminFichier);
                List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(json);
                return produits;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite lors de la lecture du fichier JSON : " + ex.Message);
                return null;
            }
        }

    }

}
