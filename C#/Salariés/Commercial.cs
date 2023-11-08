using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariés
{
    public class Commercial : Employe
    {
        protected decimal primes;

        public Commercial(string nom, string prenom, int age, decimal salaire, decimal primes) : base(nom, prenom, age, salaire)
        {
            this.primes = primes;
        }

        public override decimal CalculerSalaire()
        {
            return 50 + primes;
        }
    }
}
