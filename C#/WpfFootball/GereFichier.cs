using System;
using System.IO;

namespace Wpffootball
{
    class GereFichier
    {
        public string Contenu { get; set; }
        public string NomFichier { get; set; }

        public GereFichier(string contenu, string nomFichier)
        {
            Contenu = contenu;
            NomFichier = nomFichier;
        }

        public void CreerFichierJson<T>(T contenu, string nomFichier)
        {
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(contenu, Newtonsoft.Json.Formatting.Indented);
                using (StreamWriter file = File.CreateText(nomFichier))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
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
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
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
    }
}