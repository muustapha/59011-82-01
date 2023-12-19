using System.Windows.Controls;
using System.Windows;
using System;
using WpfStock.Controllers;
using WpfStock.Models.Data;
using WpfStock.Models.Dtos;
using WpfStock.Vue;
using WpfStock;

public partial class MainWindow : Window
{
    private ArticleController _articleController;
    private CategorieController _categorieController;
    private TypesProduitController _typesProduitController;

    public MainWindow()
    {
        InitializeComponent();
        var context = new GestionstocksContext();
        _articleController = new ArticleController(context);
        _categorieController = new CategorieController(context);
        _typesProduitController = new TypesProduitController(context);
     
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void Button_Click_article(object sender, RoutedEventArgs e)
    {


    }
}