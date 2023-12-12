using System;
using System.Collections.Generic;

namespace WpfScaffoldFootball.Models.Data;

public partial class Equipe
{
    public int IdEquipe { get; set; }

    public string Nom { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string Pays { get; set; } = null!;

    public string StadePrincipal { get; set; } = null!;

    public string SiteWeb { get; set; } = null!;

    public virtual ICollection<Equipespartitum> Equipespartita { get; set; } = new List<Equipespartitum>();

    public virtual ICollection<Relation> Relations { get; set; } = new List<Relation>();
}
