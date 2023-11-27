using System;
using System.Collections.Generic;

namespace API1.Models;

public partial class Arbitre
{
    public int IdArbitre { get; set; }

    public string Nom { get; set; } = null!;

    public string Prénom { get; set; } = null!;

    public int Age { get; set; }

    public string Poste { get; set; } = null!;
}
