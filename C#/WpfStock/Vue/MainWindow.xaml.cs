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
using System.Windows.Shapes;
using WpfStock.Controllers;

namespace WpfStock.Vue
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
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
            var articleWindow = new WpfStock.Vue.Article();

            // Afficher la fenêtre Article
            articleWindow.Show();
        }

        private void Button_Click_Categorie(object sender, RoutedEventArgs e)
        {
            var CategorieWindow = new WpfStock.Vue.Categorie();

            // Afficher la fenêtre Categorie
            CategorieWindow.Show();
        }

        private void Button_Click_TypesProduit(object sender, RoutedEventArgs e)
        {
            var TypesProduitWindow = new WpfStock.Vue.TypesProduit();

            // Afficher la fenêtre Article
            TypesProduitWindow.Show();

        }
    }
}
