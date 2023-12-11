using System;
using System.Collections.Generic;

namespace WpfScaffoldFootball.Models.Data;

public partial class Arbitrespartitum
{
    public int IdArbitresPartita { get; set; }

    public int IdPartita { get; set; }

    public int IdArbitres { get; set; }

    public virtual Arbitre IdArbitresNavigation { get; set; } = null!;

    public virtual Partitum IdPartitaNavigation { get; set; } = null!;
}
