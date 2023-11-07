using entreprise_national;

class Program
{
    static void Main(string[] args)
    {
        Employe[] employes = new Employe[5]
        {
            new Employe { Nom = "JABAR", Prenom = "ABDOUL", DateDEmbauche = new DateTime(2010, 1, 1), Fonction = "ACTEUR", Salaire = 50000, Service = "R&D",EnfantsAges = new List<int> { 9, 13, 15 } },
            new Employe { Nom = "MOULIN", Prenom = "JEAN", DateDEmbauche = new DateTime(2015, 1, 1), Fonction = "DEVELOPPEUR", Salaire = 35000, Service = "CHEF",EnfantsAges = new List<int> { 5, 10, 15 } },
            new Employe { Nom = "XIMWI", Prenom = "CHUN", DateDEmbauche = new DateTime(2018, 1, 1), Fonction = "RESISTANT", Salaire = 40000, Service = "DIRECTION",EnfantsAges = new List<int> { 11, 13 } },
            new Employe { Nom = "ELKHATTABI", Prenom = "ADELKRIM", DateDEmbauche = new DateTime(2012, 1, 1), Fonction = "RESISTANT", Salaire = 60000, Service = "HEROS" , EnfantsAges = new List < int > { 3, 6, 9 }},
            new Employe { Nom = "MARCEAUX", Prenom = "SOPHIE", DateDEmbauche = new DateTime(2011, 1, 1), Fonction = "ACTRICE", Salaire = 45000, Service = "1ER",EnfantsAges = new List<int> { 15 }     }
        };

        foreach (Employe employe in employes)
        {
            employe.OrdreDeTransfert();
            employe.DistribuerChequesNoel();
        }

        Console.WriteLine("Nombre d'employés : " + employes.Length);

        var employesTries = employes.OrderBy(e => e.Nom).ThenBy(e => e.Prenom);
        foreach (var employe in employesTries)
        {
            Console.WriteLine(employe.Nom + employe.Prenom);
        }

        var employesTriesParService = employes.OrderBy(e => e.Service).ThenBy(e => e.Nom).ThenBy(e => e.Prenom);
        foreach (var employe in employesTriesParService)
        {
            Console.WriteLine($"{employe.Service} {employe.Nom} {employe.Prenom}");
        }

        double coutTotal = employes.Sum(e => e.Salaire + e.CalculerPrime());
        Console.WriteLine("Coût total des salaires et primes : " + coutTotal);

        

    } 
}






