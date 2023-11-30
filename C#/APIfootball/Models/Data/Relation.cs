using System;
using System.Collections.Generic;

namespace APIfootball;

public partial class Relation
{
    public int IdRelation { get; set; }

    public int IdEquipe { get; set; }

    public int IdJoueur { get; set; }

    public DateTime DateDebutContract { get; set; }

    public int NumeroDeMaillot { get; set; }

    public int Salaire { get; set; }

    public virtual Joueur Joueur { get; set; }
    public virtual Equipe Equipe { get; set; }
}
