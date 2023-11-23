using System;
using System.Collections.Generic;

namespace PersonnesApi.data.Models;

public partial class Personne
{
    public int Id { get; set; }

    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public sbyte Age { get; set; }
}
