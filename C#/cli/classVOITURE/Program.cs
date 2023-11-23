using System;

namespace c_Sharp
{
    public class Program
    {

        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("Citroën", "C4", "", 10000, "");
            Voiture voiture2 = new Voiture("Renault", "Kadjar", "rouge");

            voiture1.Rouler(100);
            voiture2.Rouler(200);

            Console.WriteLine(voiture1.Description());
            Console.WriteLine(voiture2.Description());
        }
    }
}