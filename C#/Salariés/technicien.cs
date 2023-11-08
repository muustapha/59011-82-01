using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salariés
{
    public class Technicien : Employe
    {
        public Technicien(string nom, string prenom, int age) : base(nom, prenom, age, 40)
        {
        }
    }

}
