using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariés
{
    public class Interimaire : Technicien
    {
        protected decimal heuresTravaillees;

        public Interimaire(string nom, string prenom, int age, decimal heuresTravaillees) : base(nom, prenom, age)
        {
            this.heuresTravaillees = heuresTravaillees;
        }

        public override decimal CalculerSalaire()
        {
            return this.heuresTravaillees * 0.5m;
        }
    }
}
