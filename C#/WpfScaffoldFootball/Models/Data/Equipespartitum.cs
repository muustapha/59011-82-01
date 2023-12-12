using System;
using System.Collections.Generic;

namespace WpfScaffoldFootball.Models.Data;

public partial class Equipespartitum
{
    public int IdEquipesPartita { get; set; }

    public int IdPartita { get; set; }

    public int IdEquipe { get; set; }

    public virtual Equipe IdEquipeNavigation { get; set; } = null!;

    public virtual Partitum IdPartitaNavigation { get; set; } = null!;
}
