using System;
using System.Security.Cryptography.X509Certificates;

namespace Salariés
{
    public abstract class Employe
    {
        protected string nom;
        protected string prenom;
        protected int age;
        protected decimal salaire;

        public Employe(string nom, string prenom, int age, decimal salaire)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.salaire = salaire;
        }
        protected Employe(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.salaire = 0;
        }
        public abstract decimal CalculerSalaire();


        public virtual string AfficherCaracteristiques()
        {
            return $"Nom: {this.nom}, Prénom: {this.prenom}, Age: {this.age}, Salaire:" +
                $" {this.salaire}";
        }
    }
}

   

    
   
    