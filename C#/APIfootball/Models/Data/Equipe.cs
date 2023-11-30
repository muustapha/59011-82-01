using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace APIfootball;

public partial class Equipe
{
    public int IdEquipe { get; set; }

    public string Nom { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Pays { get; set; } = null!;

    public string StadePrincipal { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;

    public int IdPartita { get; set; }

    public virtual Partita Partita { get; set; }
    public virtual ICollection<Relation> Relation{ get; set; }
}
