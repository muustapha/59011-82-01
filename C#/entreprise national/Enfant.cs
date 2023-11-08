using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entreprise_national
{
    public class Enfant
    {

        public string NomEnfant { get; set; }
        public string PrenomEnfant { get; set; }
        public int Age { get; set; }

        public Enfant(int age)
        {
            Age = age;
        }

    }
}
