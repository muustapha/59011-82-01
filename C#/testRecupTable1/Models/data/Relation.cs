using System;
using System.Collections.Generic;

namespace testRecupTable1.Models.data;

public partial class Relation
{
    public int IdRelation { get; set; }

    public int IdEquipe { get; set; }

    public int IdJoueur { get; set; }

    public DateTime DateDebutContract { get; set; }

    public int NumeroDeMaillot { get; set; }

    public int Salaire { get; set; }
}
