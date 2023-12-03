using System;
using System.Collections.Generic;

namespace APIfootball.Modèles.Données;

public partial class Arbitrespartitum
{
    public int IdArbitresPartita { get; set; }

    public int IdPartita { get; set; }

    public int IdArbitres { get; set; }

    public virtual Arbitre IdArbitresNavigation { get; set; } = null!;

    public virtual partita IdPartitaNavigation { get; set; } = null!;
}
