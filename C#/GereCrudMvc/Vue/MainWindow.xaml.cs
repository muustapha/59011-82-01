using System.Collections.Generic;

using System.Windows;

using GereCrudMvc.Models.Data;

namespace GereCrudMvc.Vue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private gereJson gereJson = new gereJson();

        public MainWindow()
        {
            InitializeComponent();

        }
        private const string JsonPath = @"U:\59011-82-01\C#\gereCrudMvc\produits.json";

        private void ChargerDonnees()
        {
            List<Produit> produits = gereJson.DownloaderDonnees(JsonPath);

            if (produits != null)
            {
                dtgProduit.ItemsSource = produits;
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données.");
            }
        }

       

        
        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            Produit nouveauProduit = new Produit(4, "Produit 4", 40.99, 400, "Marseille");
            AjouterProduit(nouveauProduit);
            ChargerDonnees();
        }

     
    }
}