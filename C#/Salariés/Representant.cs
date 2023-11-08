using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariés
{
    public class Representant : Commercial
    {
        protected decimal fraisDeplacement = 1;

        public Representant(string nom, string prenom, int age, decimal salaire, decimal primes) : base(nom, prenom, age, salaire, primes)
        {
        }

        public override decimal CalculerSalaire()
        {
            return base.CalculerSalaire() + this.fraisDeplacement;
        }
    }


}

