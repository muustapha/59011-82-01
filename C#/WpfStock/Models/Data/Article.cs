using System;
using System.Collections.Generic;

namespace WpfStock.Models.Data;

public partial class Article
{
    public int IdArticle { get; set; }

    public string LibelleArticle { get; set; } = null!;

    public int QuantiteStockee { get; set; }

    public int IdCategorie { get; set; }

    public virtual Categorie Categorie { get; set; }

    public Article(int idArticle, string libelleArticle, int quantiteStockee, int idCategorie)
    {
        IdArticle = idArticle;
        LibelleArticle = libelleArticle;
        QuantiteStockee = quantiteStockee;
        IdCategorie = idCategorie;

    }



    public Article(string libelleArticle, int quantiteStockee, int idCategorie)
    {
        LibelleArticle = libelleArticle;
        QuantiteStockee = quantiteStockee;
        IdCategorie = idCategorie;
    }


    public Article()
    {
    }   



}

