﻿using System;
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
using GestionCrudMvvm.Json;

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

        private const string JsonPath = @"U:\59011-82-01\C#\gereCrudMvc\produits.json";

        private void ChargerDonnees()
        {
            List<Produit> produits = gestionJson.DownloaderDonnees(JsonPath);

            if (produits != null)
            {
                dtgProduit.ItemsSource = produits;
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données.");
            }
        }
        private List<Produit> CreerListe()
        {
            List<Produit> produits = new List<Produit>
            {
                // Ajouter des produits à la liste
                new Produit(1, "Produit 1", 10.99, 2, 100, "dunkerque"),
                new Produit(2, "Produit 2", 20.99, 3, 200, "Lyon"),
                new Produit(3, "Produit 3", 30.99, 3.5, 300, "Paris")
            };

            return produits;
        }
        private void Button_Click_rempliDatagrid(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = CreerListe();
            gestionJson.UploaderDonnees(produits, JsonPath);
            ChargerDonnees();
        }

        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            Produit nouveauProduit = new Produit(4, "Produit 4", 40.99,4 , 400, "Marseille");
            AjouterProduit(nouveauProduit);
            ChargerDonnees();
        }

        public void AjouterProduit(Produit produit)
        {
            List<Produit> produits = CreerListe();
            produits.Add(produit);
            gestionJson.UploaderDonnees(produits, JsonPath);
        }


        private void Button_Click_Modifier(object sender, RoutedEventArgs e)
        {
            Produit produitModifie = new Produit(1, "Produit Modifié", 15.99,5 , 150, "Lille");
            ModifierProduit(produitModifie, 0);
            ChargerDonnees();
        }
        public void ModifierProduit(Produit produit, int index)
        {
            List<Produit> produits = CreerListe();
            if (index >= 0 && index < produits.Count)
            {
                produits[index] = produit;
                gestionJson.UploaderDonnees(produits, JsonPath);
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
                gestionJson.UploaderDonnees(produits, JsonPath);
            }
            else
            {
                MessageBox.Show("Index hors limites.");
            }
        }

        private void Button_Click_sauvegerder(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = CreerListe();
            SauvegarderProduit(produits);
            ChargerDonnees();
        }
        public void SauvegarderProduit(List<Produit> produits)
        {
            gestionJson.UploaderDonnees(produits, JsonPath);
        }


    }
}

