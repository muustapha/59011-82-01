using System;
using System.Collections.Generic;

namespace APIfootball;

public partial class Partita
{
    public int IdPartita { get; set; }

    public DateTime DateHeure { get; set; }

    public string Ligue { get; set; } = null!;

    public bool VideoAssistantReferees { get; set; }

    public int Score { get; set; }


    public virtual Arbitre Arbitre { get; set; }
    public virtual Equipe Equipe { get; set; }

}
