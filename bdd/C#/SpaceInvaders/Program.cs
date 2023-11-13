using SpaceInvaders;
class Program
{
    static void Main(string[] args)
    {
        int nbLignes = 10;
        int nbColonnes = 10;
        List<int> grille = new List<int>(20) { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Space space = new Space(nbLignes, nbColonnes, grille);
        Console.WriteLine(space.ToString());
        Invader invader = new Invader();
        Console.WriteLine(invader.ToString());
    }
}
