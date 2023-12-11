using System;
using System.Collections.Generic;

namespace WpfDbPersonne.Models.Data;

public partial class Personne
{
    public uint IdPersonne { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public int? CodePostal { get; set; }

    public string Adresse { get; set; } = null!;

    public string Ville { get; set; } = null!;

<<<<<<< HEAD
    public Personne(string nom, string prenom, int codePostal, string adresse, string ville)
    {    
=======
    public Personne(uint idPersonne, string nom, string prenom, int codePostal, string adresse, string ville)
    {   
        IdPersonne = idPersonne;
>>>>>>> b67ce01701993ec024796d17cecfcede0e52d689
        Nom = nom;
        Prenom = prenom;
        CodePostal = codePostal;
        Adresse = adresse;
        Ville = ville;
    }
<<<<<<< HEAD
=======


    public Personne(string nom, string prenom, int codePostal, string adresse, string ville)
    {
        Nom = nom;
        Prenom = prenom;
        CodePostal = codePostal;
        Adresse = adresse;
        Ville = ville;
    }

    public Personne()
    {
        Nom = null;
        Prenom = null;
        CodePostal = null;
        Adresse = null;
        Ville = null;
    }


>>>>>>> b67ce01701993ec024796d17cecfcede0e52d689
}