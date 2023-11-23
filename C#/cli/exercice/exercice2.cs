
using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Entrez une valeur numérique entière : ");
        int valeur;
        if (int.TryParse(Console.ReadLine(), out valeur)) {
            Console.WriteLine("La valeur saisie est : " + valeur);
        } else {
            Console.WriteLine("La valeur saisie n'est pas un entier valide.");
        }
    }
}