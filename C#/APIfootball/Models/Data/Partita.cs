﻿using System;
using System.Collections.Generic;

namespace APIfootball;

public partial class Partita
{
    public int IdPartita { get; set; }

    public DateTime DateHeure { get; set; }

    public string Ligue { get; set; } = null!;

    public bool VideoAssitance { get; set; }

    public string Score { get; set; }

    public virtual ICollection<Equipe> Equipes { get; set; }
    public virtual ICollection<Arbitre> Arbitres { get; set; }

}
