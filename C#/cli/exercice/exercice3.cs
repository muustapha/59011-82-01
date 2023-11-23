using System;

class Program
{
    static void Main(string[] args)
    {
        // Demander à l'utilisateur de saisir deux nombres entiers
        Console.Write("Entrez le premier nombre : ");
        int nombre1 = int.Parse(Console.ReadLine());
        Console.Write("Entrez le deuxième nombre : ");
        int nombre2 = int.Parse(Console.ReadLine());

        // Calculer la somme et le quotient des deux nombres
        int somme = nombre1 + nombre2;
        double quotient = (double)nombre1 / nombre2;

        // Afficher la somme et le quotient
        Console.WriteLine("La somme est : " + somme);
        Console.WriteLine("Le quotient est : " + quotient);
    }
  
    }