using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1

    {
        public class Client
        {
            private string CIN;
            private string Nom;
            private string Prenom;
            private int Tel;

            public string cin
            {
                get { return CIN; }
                set { CIN = value; }
            }
            public string nom
            {
                get { return Nom; }
                set { Nom = value; }
            }
            public string prenom
            {
                get { return Prenom; }
                set { Prenom = value; }
            }
            public int tel
            {
                get { return Tel; }
                set { Tel = value; }
            }
            public Client(string CNI, string nom, string prenom)
            {
                CIN = cin;
                Nom = nom;
                Prenom = prenom;
            }
            public Client(string CNI, string nom, string prenom, int tel)
            {
                CIN = cin;
                Nom = nom;
                Prenom = prenom;
                Tel = tel;
            }
            public string Afficher()
            {
                return "Le client " + Nom + " " + Prenom + " de CIN " + CIN + " et de numéro de téléphone " + Tel;
            }






        }
    }

