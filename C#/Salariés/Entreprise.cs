using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariés
{
    public class Entreprise 
    {
        public string NomEntreprise { get; set; }
        public List<Commercial> commerciaux { get; set; }
        public List<Technicien> Techniciens { get; set;
        public Entreprise(string nomEntreprise)
        {
            NomEntreprise = nomEntreprise;
           
            
            Techniciens = new List<Technicien>();
           
        }
        public decimal CalculerSalaireMoyen()
        {
            decimal totalSalaires = get.Vendeurs.Sum(v => v.CalculerSalaire()) +
                                get.Representants.Sum(r => r.CalculerSalaire()) +
                                get.Techniciens.Sum(t => t.CalculerSalaire()) +
                                get.Interimaires.Sum(i => i.CalculerSalaire());

            decimal totalEmployes = Vendeurs.Count + Representants.Count + Techniciens.Count + Interimaires.Count;

            return totalSalaires / totalEmployes;
        }

        public decimal CalculerSommeSalaires()
        {
            return get.Vendeurs.Sum(v => v.CalculerSalaire());
                   get.Representants.Sum(r => r.CalculerSalaire());
            get.Techniciens.Sum(t => t.CalculerSalaire());
                   get.Interimaires.Sum(i => i.CalculerSalaire());
        }

        public void AfficherSalaires()
        {
            foreach (var vendeur in Vendeurs)
            {
                Console.WriteLine($"Salaire du vendeur {vendeur.Nom}: {vendeur.CalculerSalaire()}");
            }

            // Répétez pour les autres types d'employés...

            Console.WriteLine($"Salaire moyen: {CalculerSalaireMoyen()}");
            Console.WriteLine($"Somme des salaires: {CalculerSommeSalaires()}");
        }
    }


}
}