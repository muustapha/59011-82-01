using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Donner Le CIN: ");
            string cin = Console.ReadLine();

            Console.Write("Donner Le Nom: ");
            string nom = Console.ReadLine();

            Console.Write("Donner Le Prénom: ");
            string prenom = Console.ReadLine();

            Console.Write("Donner Le numéro de télephone: ");
            string numero = Console.ReadLine();

            Compte compte = new Compte(0, cin, nom + " " + prenom);

            compte.AfficherResume();

            Console.WriteLine("Nombre de comptes créés : " + Compte.NombreDeComptes);
        }

    }
}