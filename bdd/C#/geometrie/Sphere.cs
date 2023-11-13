using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie;

public class Sphere : Cercle

    { 
   public Sphere (double rayon, double diametre) : base (rayon, diametre)
    { }

    public double perimetre ()
    {
        return  Math.PI * base.Diametre;
    }
    public double aire ()
    {
        return 4 * Math.PI * Math.Pow(base.Rayon, 2);
    }

    }

