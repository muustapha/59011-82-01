using System;
using System.Collections.Generic;

namespace WebApplication1.Models.Data;

public partial class Partitum
{
    public int IdPartita { get; set; }

    public DateTime DateHeure { get; set; }

    public string Ligue { get; set; } = null!;

    public int VideoAssistance { get; set; }

    public string Score { get; set; } = null!;

    public virtual ICollection<Arbitre> Arbitres { get; set; } = new List<Arbitre>();

    public virtual ICollection<Equipe> Equipes { get; set; } = new List<Equipe>();
}
