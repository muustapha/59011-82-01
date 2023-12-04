using System;
using System.Collections.Generic;

namespace APIfootball.Models.data;

public partial class Joueur
{
    public int IdJoueur { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public int Age { get; set; }

    public string Poste { get; set; } = null!;

    public string Nationalite { get; set; } = null!;

    public virtual ICollection<Relation> Relations { get; set; } = new List<Relation>();
}
