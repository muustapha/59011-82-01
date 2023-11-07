using c_Sharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Donner Le CIN: ");
        string cin = Console.ReadLine();

        Console.Write("Donner Le Nom: ");
        string nom = Console.ReadLine();

        Console.Write("Donner Le Prénom: ");
        string prenom = Console.ReadLine();

        Console.Write("Donner Le numéro de télephone: ");
        string numero = Console.ReadLine();

        Compte compte = new Compte(0, cin, nom + " " + prenom);

        compte.AfficherResume();

        Console.WriteLine("Nombre de comptes créés : " + Compte.NombreDeComptes);
    }

}