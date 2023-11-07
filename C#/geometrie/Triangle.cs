using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
        public class Triangle
        {
            public double Base { get; set; }
            public double Hauteur { get; set; }

            public Triangle()
            {
                Base = 0;
                Hauteur = 0;
            }

            public Triangle(double baseTriangle, double hauteur)
            {
                Base = baseTriangle;
                Hauteur = hauteur;
            }

        public double Hypotenuse()
        {
            return Math.Sqrt(Base * Base + Hauteur * Hauteur);
        }

        public double Perimetre()
        {
            return Base + Hauteur + Hypotenuse();
        }

        public double Aire()
            {
                return 0.5 * Base * Hauteur;
            }

            public void AfficherTriangle()
            {
            Console.WriteLine("Base: " + Base + " - Hauteur: " + Hauteur + " - Périmètre: " + Perimetre() + " - Aire: " + Aire());
        }
        }
    }

