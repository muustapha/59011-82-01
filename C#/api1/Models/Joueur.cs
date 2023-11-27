using System;
using System.Collections.Generic;

namespace API1.Models;

public partial class Joueur
{
    public int IdJoueur { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public int Age { get; set; }

    public string Poste { get; set; } = null!;

    public int Nationnalite { get; set; }
}
