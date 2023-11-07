
using c_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Sharp
{
    public class VoitureOLD
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
        }

        public VoitureOLD(string marque, string modele, string couleur = "", int nbDeKilometres = 0, string motorisation = "")
        {
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
            NbDeKilometres = nbDeKilometres;
            Motorisation = motorisation;
        }

        public string Description()
        {
            return "Cette voiture est une " + Modele + " de la marque " + Marque + " de couleur " + Couleur + ", de motorisation " + Motorisation + ", avec " + NbDeKilometres + " Kilomètres";
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Voiture voiture1 = new Voiture("Citroën", "C4", "", 10000, "");
    //        Voiture voiture2 = new Voiture("Renault", "Kadjar", "rouge");

    //        Console.WriteLine(voiture1.Description());
    //        Console.WriteLine(voiture2.Description());
    //    }
    //}
}
