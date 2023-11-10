using System.IO;

class Program
{
    static void Main()
    {
        // Exemple d'utilisation avec une variable simple
        string contenuVariableSimple = "Contenu de la variable simple";
        string nomFichierVariableSimple = @"U:\59011-82-01\C#\json\test1.txt";

        GereFichier gereFichier = new GereFichier();
        gereFichier.EcrireContenuDansFichier(contenuVariableSimple, nomFichierVariableSimple);

        // Exemple d'utilisation avec une variable de type tableau
        int[] contenuTableau = { 1, 2, 3, 4, 5 };
        string nomFichierTableau = @"U:\59011-82-01\C#\json\test1.txt";

        gereFichier.EcrireContenuTableauDansFichier(contenuTableau, nomFichierTableau);
    }
}

public class GereFichier
{
    public void EcrireContenuDansFichier(string contenu, string nomFichier)
    {
        using (StreamWriter sw = new StreamWriter(nomFichier))
        {
            sw.Write(contenu);
        }
    }

    public void EcrireContenuTableauDansFichier(int[] contenu, string nomFichier)
    {
        using (StreamWriter sw = new StreamWriter(nomFichier))
        {
            foreach (int i in contenu)
            {
                sw.Write(i + " ");
            }
        }
    }
}
