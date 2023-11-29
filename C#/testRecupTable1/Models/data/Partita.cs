using System;
using System.Collections.Generic;

namespace testRecupTable1.Models.data;

public partial class Partita
{
    public int IdPartita { get; set; }

    public DateTime Date { get; set; }

    public string Ligue { get; set; } = null!;

    public bool VideoAssistantReferees { get; set; }
}
