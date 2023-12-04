using System;
using System.Collections.Generic;

namespace APIfootball.Models.data;

public partial class Equipe
{
    public int IdEquipe { get; set; }

    public string Nom { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Pays { get; set; } = null!;

    public string StadePrincipal { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;

    public int IdPartita { get; set; }

    public virtual Partitum IdPartitaNavigation { get; set; } = null!;

    public virtual ICollection<Relation> Relations { get; set; } = new List<Relation>();
}
