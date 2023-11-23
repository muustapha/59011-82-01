public class Employe
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public DateTime DateDEmbauche { get; set; }
    public string Fonction { get; set; }
    public double Salaire { get; set; }
    public string Service { get; set; }
}
    public int AnneesDansEntreprise()
{
    int currentYear = DateTime.Now.Year;
    return currentYear - DateDEmbauche.Year;
}

    public double CalculerPrime()
    {
        int annees = AnneesDansEntreprise();
        return (Salaire * 0.05) + (Salaire * annees * 0.02);
    }

    public void OrdreDeTransfert()
    {
        if (DateTime.Now.Month == 11 && DateTime.Now.Day == 30)
        {
            double prime = CalculerPrime();
            Console.WriteLine($"L'ordre de transfert de {prime} a été envoyé à la banque.");
        }
    }
}

