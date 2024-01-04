using System;
using System.Collections.Generic;

namespace WPFGestionStock1.Models.Data;

public partial class Article
{
    public int IdArticle { get; set; }

    public string LibelleArticle { get; set; } = null!;

    public int QuantiteStockee { get; set; }

    public int IdCategorie { get; set; }

    public virtual Categorie Categorie { get; set; }

    public Article(int idArticle, string libelleArticle, int quantiteStockee, string libelleCategorie)
    {
        IdArticle = idArticle;
        LibelleArticle = libelleArticle;
        QuantiteStockee = quantiteStockee;
        Categorie.LibelleCategorie = libelleCategorie;

    }



    public Article(string libelleArticle, int quantiteStockee, string libelleCategorie)
    {
        LibelleArticle = libelleArticle;
        QuantiteStockee = quantiteStockee;
        Categorie.LibelleCategorie = libelleCategorie;
    }

    public Article()
    {
    }

}

