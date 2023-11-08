using Salariés;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Representant : Commercial
{
    protected decimal fraisDeplacement;
    decimal newprimes =5;


    public Representant(string nom, string prenom, int age, decimal salaire, decimal primes, int nombreDeplacements)
        : base(nom, prenom, age, salaire, primes)
    {
        this.fraisDeplacement = nombreDeplacements; 
    }

    public override decimal CalculerSalaire()
    {
        return salaire = base.CalculerSalaire() + this.fraisDeplacement + this.primes;
    }
}

