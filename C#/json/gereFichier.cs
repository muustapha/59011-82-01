using Newtonsoft.Json;
using System;
using System.IO;

namespace json
{
    public class GereFichier
    {
        public string Contenu { get; set; }
        public string NomFichier { get; set; }

        public GereFichier(string contenu, string nomFichier)
        {
            Contenu = contenu;
            NomFichier = nomFichier;
        }

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

        public void EcrireContenuTableauDansFichier<T>(T[] contenutableau, string nomFichierTableau)
        {
            try
            {
                using (FileStream fileStream = new FileStream(nomFichierTableau, FileMode.Create, FileAccess.Write))
                {
                    foreach (var item in contenutableau)
                    {
                        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(item.ToString() + "\n");
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }

                Console.WriteLine($"Le contenu du tableau a été écrit dans le fichier {nomFichierTableau} avec succès.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de l'écriture dans le fichier : {e.Message}");
            }
        }
        public void CreerFichierJson<T>(T contenu, string nomFichier)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contenu, Formatting.Indented);

                using (StreamWriter file = File.CreateText(nomFichier))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, json);
                }

                Console.WriteLine($"Le contenu a été écrit dans le fichier JSON {nomFichier} avec succès.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la création du fichier JSON : {e.Message}");
            }
        }

        public T LireFichierJson<T>(string nomFichier)
        {
            try
            {
                using (StreamReader file = File.OpenText(nomFichier))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    T contenu = (T)serializer.Deserialize(file, typeof(T));
                    return contenu;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier JSON : {e.Message}");
                return default(T);
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