using System;
using System.Collections.Generic;
using WPFGestionStock1.Models.Data;

namespace WPFGestionStock1.Models.Data;

public partial class TypesProduit
{
    public int IdTypeProduit { get; set; }

    public string LibelleTypeProduit { get; set; } 

    public virtual ICollection<Categorie> Categories { get; set; } = new List<Categorie>();


    public TypesProduit(int idTypeProduit, string libelleTypeProduit)
    {
        IdTypeProduit = idTypeProduit;
        LibelleTypeProduit = libelleTypeProduit;

    }

    public TypesProduit(string libelleTypeProduit)
    {
        LibelleTypeProduit = libelleTypeProduit;
    }

    public TypesProduit()
    {
    }



}
