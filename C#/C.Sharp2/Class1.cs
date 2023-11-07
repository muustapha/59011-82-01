using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp2
{
    public class Employe

    {
        public string Nom;
        public string Prenom;
        public DateTime DateDEmbauche;
        public string Fonction;
        public double Salaire;
        public string Service;

        public string nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public DateTime dateDEmbauche
        {
            get { return dateDEmbauche; }
            set { dateDEmbauche = value; }
        }
        public string fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }
        public double salaire;
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public Employe (string nom, string prenom, DateTime dateDEmbauche,string fonctinnaire, double salaire, string service,)
        {
            Nom = nom;
            Prenom = prenom;
            DateDEmbauche = dateDEmbauche;
            Fonction = fonction;
            Salaire = salaire;
            Service = service;
        }


        public string ancienter()
        {
            DateTime date = DateTime.Now;
            TimeSpan anciennete = date - DateDEmbauche;
            return anciennete.ToString();
        }














        public Employe(string nom, string prenom, DateTime dateDEmbauche, string fonction, double salaire, string service)
        {
            Nom = nom;
            Prenom = prenom;
            DateDEmbauche = dateDEmbauche;
            Fonction = fonction;
            Salaire = salaire;
            Service = service;
        }

       
    }













}
}
