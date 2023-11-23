using Salariés;

public class Entreprise
{
    public string NomEntreprise { get; set; }
    public List<Commercial> Commerciaux { get; set; }
    public List<Technicien> Techniciens { get; set; }

    public Entreprise(string nomEntreprise)
    {
        NomEntreprise = nomEntreprise;
        Commerciaux = new List<Commercial>();
        Techniciens = new List<Technicien>();
    }

    public decimal CalculerSalaireMoyen()
    {
        decimal totalSalaires = Commerciaux.Sum(c => c.CalculerSalaire()) +
                                Techniciens.Sum(t => t.CalculerSalaire());

        decimal totalEmployes = Commerciaux.Count + Techniciens.Count;

        return totalSalaires / totalEmployes;
       
    }

    public decimal CalculerSommeSalaires()
    {
        return Commerciaux.Sum(c => c.CalculerSalaire()) +
               Techniciens.Sum(t => t.CalculerSalaire());

          
 }
    public void AfficherSalaires()
    {
         
        foreach (Commercial commercial in Commerciaux)
        {
            Console.WriteLine(commercial.AfficherCaracteristiques());
        }

        foreach (Technicien technicien in Techniciens)
        {
            Console.WriteLine(technicien.AfficherCaracteristiques());
        }
        
        Console.WriteLine("Le salaire moyen est de : " + CalculerSalaireMoyen());
        Console.WriteLine("La somme des salaires est de : " + CalculerSommeSalaires()); 
    }

}