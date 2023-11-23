using geometrie;
    
public class Pyramide : TriangleRectangle
{
    public double HauteurPyramide { get; set; }

    public Pyramide(double Base, double Hauteur, double hauteurPyramide) : base(Base, Hauteur)
    {
        HauteurPyramide = hauteurPyramide;
    }
    public double Perimetre()
    {
        return base.Perimetre() *2 + HauteurPyramide;
    }

    public double Volume()
    {
        return base.Aire() * HauteurPyramide ;
    }


}