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

        private void Button_Click_rempliDatagrid(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = CreerListe();
            gereJson.UploaderDonnees(produits, JsonPath);
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

        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            Produit nouveauProduit = new Produit(4, "Produit 4", 40.99, 400, "Marseille");
            AjouterProduit(nouveauProduit);
            ChargerDonnees();
        }

        public void AjouterProduit(Produit produit)
        {
            List<Produit> produits = CreerListe();
            produits.Add(produit);
            gereJson.UploaderDonnees(produits, JsonPath);
        }

        
        private void Button_Click_Modifier(object sender, RoutedEventArgs e)
        {
            Produit produitModifie = new Produit(1, "Produit Modifié", 15.99, 150, "Lille");
            ModifierProduit(produitModifie, 0);
            ChargerDonnees();
                    }
        public void ModifierProduit(Produit produit, int index)
        {
            List<Produit> produits = CreerListe();
            if (index >= 0 && index < produits.Count)
            {
                produits[index] = produit;
                gereJson.UploaderDonnees(produits, JsonPath);
            }
            else
            {
                MessageBox.Show("Index hors limites.");
            }
        }
        private void Button_Click_supprimer(object sender, RoutedEventArgs e)
        {
            SupprimerProduit(0);
            ChargerDonnees();
                    }

        public void SupprimerProduit(int index)
        {
            List<Produit> produits = CreerListe();
            if (index >= 0 && index < produits.Count)
            {
                produits.RemoveAt(index);
                gereJson.UploaderDonnees(produits, JsonPath);
            }
            else
            {
                MessageBox.Show("Index hors limites.");
            }
        }

        private void Button_Click_sauvegarder(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = CreerListe();
            SauvegarderProduits(produits);
            ChargerDonnees();
                    }
        public void SauvegarderProduits(List<Produit> produits)
        {
            gereJson.UploaderDonnees(produits, JsonPath);
        }
    }
}