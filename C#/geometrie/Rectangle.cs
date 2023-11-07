using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    public class Rectangle
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle() { }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public double Perimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        public double Aire()
        {
            return Longueur * Largeur;
        }

        public bool EstCarre()
        {
            return Longueur == Largeur;
        }

        public void AfficherRectangle()
        {
            Console.WriteLine("Longueur : " + Longueur + "- Largeur : " + Largeur + "- Périmètre : " + Perimetre() + "- Aire : " + Aire() + (EstCarre() ? " - Il s'agit d'un carré" : " - Il ne s'agit pas d'un carré"));
        }
    }
}
