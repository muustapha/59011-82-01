using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
    using System;
    using System.IO;

    public class GereFichier
    {
        public void EcrireContenuDansFichier(string contenu, string nomFichier)
        {
            try
            {
                using (FileStream fileStream = new FileStream(nomFichier, FileMode.Create, FileAccess.Write))
                {
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(contenu);
                    fileStream.Write(bytes, 0, bytes.Length);
                }

                Console.WriteLine($"Le contenu a été écrit dans le fichier {nomFichier} avec succès.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de l'écriture dans le fichier : {e.Message}");
            }
        }

        public void EcrireContenuTableauDansFichier<T>(T[] contenu, string nomFichier)
        {
            try
            {
                using (FileStream fileStream = new FileStream(nomFichier, FileMode.Create, FileAccess.Write))
                {
                    foreach (var item in contenu)
                    {
                        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(item.ToString());
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }

                Console.WriteLine($"Le contenu du tableau a été écrit dans le fichier {nomFichier} avec succès.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de l'écriture dans le fichier : {e.Message}");
            }
        }
        public string LireContenuFichier(string nomFichier)
        {
            try
            {
                // Vérifier si le fichier existe
                if (!File.Exists(nomFichier))
                {
                    Console.WriteLine($"Le fichier {nomFichier} n'existe pas.");
                    return null;
                }

                // Lire le contenu du fichier
                using (StreamReader reader = new StreamReader(nomFichier))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier : {e.Message}");
                return null;

            }
        }
    }
}
