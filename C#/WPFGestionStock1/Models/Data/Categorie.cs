using System;
using System.Collections.Generic;

namespace WPFGestionStock1.Models.Data;

public partial class Categorie
{ 
    public Categorie()
    {
        Articles = new HashSet<Article>();
    }
    public int IdCategorie { get; set; }

    public string LibelleCategorie { get; set; } = null!;

    public int IdTypeProduit { get; set; }

    public virtual ICollection<Article> Articles { get; set; }

    public virtual TypesProduit TypesProduit { get; set; } = null!;
}
