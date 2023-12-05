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
using GestionCrudMvvm.Controllers;
using GestionCrudMvvm.Json;
using GestionCrudMvvm.vue;

namespace GestionCrudMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private gestionJson gestionJson = new gestionJson();


        private const string JsonPath = @"C:\Users\utilisateur\Desktop\GIT\Nouveau dossier\59011-82-01\C#\GestionCrudMvvmproduits.json";


        public List<Produit> ChargerDonnees()
        {
            List<Produit> produits = gestionJson.chargerDonnees(JsonPath);

            if (produits == null)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données.");
                produits = new List<Produit>();
            }

            return produits;
        }

        public void AjouterProduit(Produit produit)
        {
            List<Produit> produits = ChargerDonnees();
            produits.Add(produit);
            gestionJson.UploaderDonnees(produits, JsonPath);
        }

        public void ModifierProduit(Produit produit)
        {
            List<Produit> produits = ChargerDonnees();
            int index = produits.FindIndex(p => p.IdProduit == produit.IdProduit);
            if (index != -1)
            {
                produits[index] = produit;
                gestionJson.UploaderDonnees(produits, JsonPath);
            }
            else
            {
                MessageBox.Show("Produit non trouvé.");
            }
        }

        public void SupprimerProduit(int index)
        {
            List<Produit> produits = ChargerDonnees();
            if (index >= 0 && index < produits.Count)
            {
                produits.RemoveAt(index);
                gestionJson.UploaderDonnees(produits, JsonPath);
            }
            else
            {
                MessageBox.Show("Index hors limites.");
            }
        }
        public void SauvegarderProduit(List<Produit> produits)
        {
            gestionJson.UploaderDonnees(produits, JsonPath);
        }

        private void Button_Click_rempliDatagrid(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = ChargerDonnees();
            gestionJson.UploaderDonnees(produits, JsonPath);
            ChargerDonnees();
        }

        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            AjouterProduit ajouterProduitWindow = new AjouterProduit();
            ajouterProduitWindow.Show();
        }

        private void Button_Click_Modifier(object sender, RoutedEventArgs e)
        {
            ModifierProduit modifierProduitWindow = new ModifierProduit();
            modifierProduitWindow.Show();
        }

        private void Button_Click_supprimer(object sender, RoutedEventArgs e)
        {
            SupprimerProduit(0);
            ChargerDonnees();
        }

        private void Button_Click_sauvegerder(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = ChargerDonnees();
            SauvegarderProduit(produits);
            ChargerDonnees();
        }
    }
}

