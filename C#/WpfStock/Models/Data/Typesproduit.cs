using System;
using System.Collections.Generic;
using WpfStock.Models.Data;

namespace WpfStock;

public partial class TypesProduit
{
    public int IdTypeProduit { get; set; }

    public string LibelleTypeProduit { get; set; } = null!;

    public virtual ICollection<Categorie> Categories { get; set; } = new List<Categorie>();


    public TypesProduit()
    { }





}
