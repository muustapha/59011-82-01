using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1

    {
        public class Compte
        {
            public double Solde;
            public string Code;
            public string Proprietaire;
            private static int nombreDeComptes = 0;



            public double solde
            {
                get { return Solde; }
                set { Solde = value; }
            }
            public string code
            {
                get { return Code; }
                set { Code = value; }
            }
            public string proprietaire
            {
                get { return Proprietaire; }
                set { Proprietaire = value; }
            }

            public static int NombreDeComptes
            {
                get { return nombreDeComptes; }
            }

            public Compte(double solde, string code, string proprietaire)
            {
                Solde = solde;
                Code = code;
                Proprietaire = proprietaire;
                nombreDeComptes++;
            }


            public void Crediter(double somme)
            {
                Solde = Solde + somme;
            }


            public void Crediter(double somme, Compte compte)
            {
                Solde = Solde + somme;
                compte.Solde = compte.Solde - somme;
            }

            public void Debiter(double somme)
            {
                Solde = Solde - somme;
            }

            public void Debiter(double somme, Compte compte)
            {
                if (Solde >= somme)
                {
                    Solde = Solde - somme;
                    compte.Solde = compte.Solde + somme;
                }
                else
                {
                    Console.WriteLine("Solde insuffisant pour effectuer cette opération.");
                }
            }
            //Une méthode qui permet d’afficher le résumé d’un compte
            public void AfficherResume()
            {
                Console.WriteLine("Code du compte" + Code);
                Console.WriteLine("Propriétaire" + Proprietaire);
                Console.WriteLine("Solde:" + Solde);
            }



            public static void AfficherNombreDeComptes()
            {
                Console.WriteLine($"Nombre de comptes créés: {nombreDeComptes}");
            }
        }
    }

