using System;
using System.Collections.Generic;

namespace APIfootball.Models.data;

public partial class Partitum
{
    public int IdPartita { get; set; }

    public DateTime DateHeure { get; set; }

    public string Ligue { get; set; } = null!;

    public bool VideoAssitance { get; set; }

    public string Score { get; set; } = null!;

    public virtual ICollection<Arbitrespartitum> Arbitrespartita { get; set; } = new List<Arbitrespartitum>();

    public virtual ICollection<Equipe> Equipes { get; set; } = new List<Equipe>();
}
