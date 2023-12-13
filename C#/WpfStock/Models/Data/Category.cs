using System;
using System.Collections.Generic;

namespace WpfStock;

public partial class Categorie
{
    public int IdCategorie { get; set; }

    public string LibelleCategorie { get; set; } = null!;

    public int IdTypeProduit { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual TypesProduit IdTypeProduitNavigation { get; set; } = null!;
}
