using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    public class Parallelepipede : Rectangle
    {
        public double Hauteur { get; set; }

        public Parallelepipede(double longueur, double largeur, double hauteur) : base(longueur, largeur)
        {
            Hauteur = hauteur;
        }
        public double Perimetre()
        {
            return base.Perimetre() * 2 + Hauteur * 4;
        }
        public double Volume()
        {
            return base.Aire() * Hauteur;
        }
        public void AfficherParallelepipede()
        {
            Console.WriteLine("Longueur : " + Longueur + "- Largeur : " + Largeur + "- Hauteur : " + Hauteur + "- Périmètre : " + Perimetre() + "- Volume : " + Volume());
        }
    }
}
        