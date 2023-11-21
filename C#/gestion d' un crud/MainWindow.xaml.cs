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

namespace gestion_d__un_crud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GestionnaireJson gestionnaireJson = new GestionnaireJson();

        public MainWindow()
        {
            InitializeComponent();
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            List<Produit> produits = gestionnaireJson.DownloaderDonnees(@"U:\59011-82-01\C#\gestion d' un crud\produits.json");

            if (produits != null)
            {
                dtgProduit.ItemsSource = produits;
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = CreerListe();
            gestionnaireJson.UploaderDonnees(produits, @"U:\59011-82-01\C#\gestion d' un crud\produits.json");
            ChargerDonnees();
        }

        private List<Produit> CreerListe()
        {
            List<Produit> produits = new List<Produit>
    {
        // Ajouter des produits à la liste
        new Produit(1, "Produit 1", 10.99, 100, "dunkerque"),
        new Produit(2, "Produit 2", 20.99, 200, "Lyon"),
        new Produit(3, "Produit 3", 30.99, 300, "Paris")
    };

            return produits;
        }
    }
}