using System;

namespace Salariés
{
    public class Employe
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

        public virtual decimal CalculerSalaire()
        {
            return this.salaire;
        }

        public string AfficherCaracteristiques()
        {
            return $"Nom: {this.nom}, Prénom: {this.prenom}, Age: {this.age}, Salaire: {this.salaire}";
        }
    }
}

   

    
   
    