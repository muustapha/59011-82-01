using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    public class Cercle
    {
        public double Diametre { get; set; }

        public Cercle()
        {
            Diametre = 0;
        }

        public Cercle(double diametre)
        {
            Diametre = diametre;
        }

        public double Perimetre()
        {
            return Math.PI * Diametre;
        }

        public double Aire()
        {
            double rayon = Diametre / 2;
            return Math.PI * Math.Pow(rayon, 2);
        }

        public void AfficherCercle()
        {
            Console.WriteLine("Diamètre: " + Diametre + " - Périmètre: " + Perimetre() + " - Aire: " + Aire());
        }
    }
}
