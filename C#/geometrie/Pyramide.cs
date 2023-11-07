using geometrie;

public class Pyramide : Triangle
{
    public double HauteurPyramide { get; set; }

    public Pyramide(double baseTriangle, double hauteurTriangle, double hauteurPyramide) : base(baseTriangle, hauteurTriangle)
    {
        HauteurPyramide = hauteurPyramide;
    }

    public double AireBase()
    {
        return 0.5 * Base * Hauteur;
    }
    public override double Aire()
    {
        double aireBase = base.Aire();
        double aireCotes = 0.5 * Perimetre() * HauteurPyramide;
        return aireBase + aireCotes;
    }

    public double Volume()
    {
        return (1.0 / 3.0) * base.Aire() * HauteurPyramide;
    }

    public override void AfficherTriangle()
    {
        Console.WriteLine($"Base: {Base} - Hauteur Triangle: {Hauteur} - Hauteur Pyramide: {HauteurPyramide} - Aire: {Aire()} - Volume: {Volume()}");
    }

    public double Perimetre()
    {
        return Base * 3;
    }
}