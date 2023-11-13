using System.IO;
using json;

public class Program
{
    static void Main()
    {    // Créer une instance de ObjectsHelpers
        ObjectsHelpers objectsHelpers = new ObjectsHelpers();

        // Définir le chemin d'accès au fichier de journalisation et le contenu à écrire
        string path = @"C:\Users\utilisateur\Desktop\59011-82-01\59011-82-01\C#\json\log.txt";
        string contenu = "Ceci est un message de journalisation.";

        // Appeler la méthode Log
        bool result = objectsHelpers.Log(path, contenu);

        // Vérifier le résultat
        if (result)
        {
            Console.WriteLine("Le message a été écrit dans le journal avec succès.");
        }
        else
        {
            Console.WriteLine("Échec de l'écriture du message dans le journal.");
        
    }
        // Exemple d'utilisation avec une variable simple
        string contenuVs = "Contenu de la variable simple";
        string nomFichier = @"C:\Users\utilisateur\Desktop\59011-82-01\59011-82-01\C#\json\test1.txt";

        GereFichier gereFichier = new GereFichier(contenuVs, nomFichier);
        gereFichier.EcrireContenuDansFichier(contenuVs, nomFichier);

        // Exemple d'utilisation avec une variable de type tableau
        int[] contenuTableau = { 1, 2, 3, 4, 5 };
        string nomFichierTableau = @"C:\Users\utilisateur\Desktop\59011-82-01\59011-82-01\C#\json\test2.txt";

        gereFichier.EcrireContenuTableauDansFichier(contenuTableau, nomFichierTableau);

        // Créer un objet à écrire dans le fichier JSON
        var monObjet = new
        {
            Nom = "Aftiss",
            Age = 40
        };
        string monFichierJson = @"C:\Users\utilisateur\Desktop\59011-82-01\59011-82-01\C#\json\test3.json";

        gereFichier.CreerFichierJson(monObjet, monFichierJson);
    }
}