using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Data;

public partial class Relation
{
    public int IdRelation { get; set; }

    public int IdEquipe { get; set; }

    public int IdJoueur { get; set; }

    public DateTime DateDebutContract { get; set; }

    public int NumeroDeMaillot { get; set; }

    public int Salaire { get; set; }

    public virtual Equipe IdEquipeNavigation { get; set; } = null!;

    public virtual Joueur IdJoueurNavigation { get; set; } = null!;
}
