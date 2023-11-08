using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
        public class TriangleRectangle
        {
            public double Base { get; set; }
            public double Hauteur { get; set; }

            public TriangleRectangle()
            {
                Base = 0;
                Hauteur = 0;
            }

            public TriangleRectangle(double baseTriangleRectangle, double hauteur)
            {
                Base = baseTriangleRectangle;
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

            public void AfficherTriangleRectangle()
            {
            Console.WriteLine("Base: " + Base + " - Hauteur: " + Hauteur + " - Périmètre: " + Perimetre() + " - Aire: " + Aire());
        }
        }
    }

