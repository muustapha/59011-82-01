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




        public MainWindow()
        {
            InitializeComponent();
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            List<Produit> produits = gestionnaireJson.LireFichierJson<List<Produit>>(@"U:\59011-82-01\C#\gestion d' un crud\produits.json");

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
            gestionnaireJson.CreerFichierJson(produits, @"U:\59011-82-01\C#\gestion d' un crud\produits.json");

            GestionnaireJson gestionnaireJson = new GestionnaireJson();
            List<Produit> produits = gestionnaireJson.DownloaderDonnees("");

            if (produits != null)
            {
                dtgProduit.ItemsSource = produits;
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données.");
            }

        }
    }
}