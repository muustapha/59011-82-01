using System;
using System.Collections.Generic;

namespace WpfScaffoldFootball.Models.Data;

public partial class Partitum
{
    public int IdPartita { get; set; }

    public DateTime DateHeure { get; set; }

    public string Ligue { get; set; } = null!;

    public bool VideoAssitance { get; set; }

    public string Score { get; set; } = null!;

    public virtual ICollection<Arbitrespartitum> Arbitrespartita { get; set; } = new List<Arbitrespartitum>();

    public virtual ICollection<Equipespartitum> Equipespartita { get; set; } = new List<Equipespartitum>();
}
