using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entreprise_national
{
 
    public class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDEmbauche { get; set; }
        public string Fonction { get; set; }
        public double Salaire { get; set; }
        public string Service { get; set; }
        public Agence Agence { get; set; }
        public  List<int> Age { get; set; }




        public int AnneesDansEntreprise()
        {
            int anneeActuel = DateTime.Now.Year;
            return anneeActuel - DateDEmbauche.Year;
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
                Console.WriteLine("L'ordre de transfert de" + prime + " a été envoyé à la banque.");
            }
        }

        public bool PeutRecevoirChequesVacances()
        {
            return AnneesDansEntreprise() >= 1;
        }

        public void DistribuerChequesNoel()
        {
            if (Age == null || Age.Count == 0)
            {
                Console.WriteLine("Non");
                return;
            }

            int cheques20 = Age.Count(age => age >= 0 && age <= 10);
            int cheques30 = Age.Count(age => age >= 11 && age <= 15);
            int cheques50 = Age.Count(age => age >= 16 && age <= 18);

            Console.WriteLine("Oui");
            if (cheques20 > 0) Console.WriteLine("Chèques de 20 euros : " + cheques20);
            if (cheques30 > 0) Console.WriteLine("Chèques de 30 euros : " + cheques30);
            if (cheques50 > 0) Console.WriteLine("Chèques de 50 euros : " + cheques50);
        }
    }

}