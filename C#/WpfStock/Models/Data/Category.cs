using System;
using System.Collections.Generic;

namespace WpfStock;

public partial class Categorie
{ 
    public Categorie()
    {
        Articles = new HashSet<Categorie>();
    }
    public int IdCategorie { get; set; }

    public string LibelleCategorie { get; set; } = null!;

    public int IdTypeProduit { get; set; }

    public virtual ICollection<Categorie> Articles { get; set; } = new List<Categorie>();

    public virtual TypesProduit IdTypeProduitNavigation { get; set; } = null!;
}
