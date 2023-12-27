using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFGestionStock1.Controllers;
using WPFGestionStock1.Models;

namespace WPFGestionStock1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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







        private void Button_Click_article(object sender, RoutedEventArgs e)
        {
            var articleWindow = new WPFGestionStock1.Vue.Article();

            // Afficher la fenêtre Article
            articleWindow.Show();
        }

        private void Button_Click_Categorie(object sender, RoutedEventArgs e)
        {
            var CategorieWindow = new WPFGestionStock1.Vue.Categorie();

            // Afficher la fenêtre Categorie
            CategorieWindow.Show();
        }

        private void Button_Click_TypesProduit(object sender, RoutedEventArgs e)
        {
            var TypesProduitWindow = new WPFGestionStock1.Vue.TypesProduit();

            // Afficher la fenêtre Article
            TypesProduitWindow.Show();

        }
    }
}
