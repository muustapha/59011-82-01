using System;
using System.Collections.Generic;
using WPFGestionStock1.Models.Data;

namespace WPFGestionStock1;

public partial class TypesProduit
{
    public int IdTypeProduit { get; set; }

    public string LibelleTypeProduit { get; set; } = null!;

    public virtual ICollection<Categorie> Categories { get; set; } = new List<Categorie>();


    public TypesProduit()
    { }





}
