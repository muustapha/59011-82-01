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

        public override double Aire()
        {
            return 4 * Aire

        public double Volume()
        {
            return Longueur * Largeur * Hauteur;
        }

        public void AfficherParallelepipede()
        {
            Console.WriteLine($"Longueur: {Longueur} - Largeur: {Largeur} - Hauteur: {Hauteur} - Aire: {Aire()} - Volume: {Volume()}");
        }
    }
}
