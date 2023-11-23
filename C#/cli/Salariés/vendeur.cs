using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariés
{
    public class Vendeur : Commercial
    {
        private decimal prime = 2;

        public Vendeur(string nom, string prenom, int age, decimal salaire, decimal primes) : base(nom, prenom, age, salaire, primes)
        {
        }

        public override decimal CalculerSalaire()
        {
            return base.CalculerSalaire() + prime;
        }
    }
}