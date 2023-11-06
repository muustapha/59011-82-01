using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Sharp
{
     public class Voiture
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int NbDeKilometres { get; set; }
        public string Motorisation { get; set; }

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
            return $"Cette voiture est une {Modele} de la marque {Marque}, de couleur {Couleur}, de motorisation {Motorisation}, avec {NbDeKilometres} Kilomètres";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("Citroën", "C4", "", 10000, "");
            Voiture voiture2 = new Voiture("Renault", "Kadjar", "rouge");

            Console.WriteLine(voiture1.Description());
            Console.WriteLine(voiture2.Description());
        }
    }
    
    }

