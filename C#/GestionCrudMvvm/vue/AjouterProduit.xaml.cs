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




namespace GestionCrudMvvm.vue
{
    /// <summary>
    /// Logique d'interaction pour AjouterProduit.xaml
    /// </summary>
    public partial class AjouterProduit : Window
    {

        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            int idProduit;
            if (!int.TryParse(txtId.Text, out idProduit))
            {
                // Gérer l'erreur de conversion pour idProduit
                return;
            }

            string nom = txtNom.Text;

            double prix;
            if (!double.TryParse(txtPrix.Text, out prix))
            {
                // Gérer l'erreur de conversion pour prix
                return;
            }

            double coutProduction;
            if (!double.TryParse(txtCout.Text, out coutProduction))
            {
                // Gérer l'erreur de conversion pour coutProduction
                return;
            }

            int quantite;
            if (!int.TryParse(txtQuantite.Text, out quantite))
            {
                // Gérer l'erreur de conversion pour quantite
                return;
            }

            string lieuxProduction = txtVille.Text;
            Produit nouveauProduit = new Produit(idProduit,nom, prix, coutProduction, quantite, lieuxProduction);

            // Ajoutez le nouveau produit à la liste et mettez à jour le fichier JSON
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.AjouterProduit(nouveauProduit);
            mainWindow.ChargerDonnees();

            // Fermez cette fenêtre
            this.Close();
        }

    }
}
