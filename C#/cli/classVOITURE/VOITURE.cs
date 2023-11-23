
using c_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Sharp
{
    public class Voiture
    {
        private string couleur;
        private string marque;
        private string modele;
        private int nbDeKilometres;
        private string motorisation;

        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }

        public int NbDeKilometres
        {
            get { return nbDeKilometres; }
            set { nbDeKilometres = value; }
        }

        public string Motorisation
        {
            get { return motorisation; }
            set { motorisation = value; }
        }p

        public Voiture(string marque, string modele, string couleur = "", int nbDeKilometres = 0, string motorisation = "")
        {
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
            NbDeKilometres = nbDeKilometres;
            Motorisation = motorisation;
        }

        public string Description()
        {
            StringBuilder description = new StringBuilder("Cette voiture est une ");

            if (!string.IsNullOrEmpty(Modele))
            {
                description.Append(Modele);
            }
            else
            {
                description.Append("modèle inconnu");
            }

            description.Append(" de la marque ");

            if (!string.IsNullOrEmpty(Marque))
            {
                description.Append(Marque);
            }
            else
            {
                description.Append("marque inconnue");
            }

            if (!string.IsNullOrEmpty(Couleur))
            {
                description.Append(" de couleur " + Couleur);
            }

            if (!string.IsNullOrEmpty(Motorisation))
            {
                description.Append(", de motorisation " + Motorisation);
            }

            description.Append(", avec " + NbDeKilometres + " Kilomètres");

            return description.ToString();
        }
        public void Rouler(int kilometre)
        {
            NbDeKilometres += kilometre;
        }
        public int Kilometre()
        {
               return NbDeKilometres;

        }


    }

    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Voiture voiture1 = new Voiture("Citroën", "C4", "", 10000, "");
    //        Voiture voiture2 = new Voiture("Renault", "Kadjar", "rouge");

    //        voiture1.Rouler(100);
    //        voiture2.Rouler(200);

    //        Console.WriteLine(voiture1.Description());
    //        Console.WriteLine(voiture2.Description());
    //    }
    //}
}