﻿using System;
using System.Collections.Generic;

namespace APIfootball;

public partial class Arbitre
{
    public int IdArbitre { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public int Age { get; set; }

    public string Poste { get; set; } = null!;


}
