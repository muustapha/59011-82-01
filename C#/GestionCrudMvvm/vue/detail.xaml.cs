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
using GestionCrudMvvm.Models;



namespace GestionCrudMvvm.vue
{
    public partial class Detail : Window
    {
        public string Mode { get; set; }

        public Detail(Produit p, MainWindow w, string mode)
        {
            InitializeComponent();
            Mode = mode;
            valider.Content = Mode;
            RemplissageChamp(p);
        }

        public void RemplissageChamp(Produit p)
        {

            if (p == null)
            {
                return;
            }

            if (Mode != "Ajouter")
            {   Nom.Text = p.Nom;
                idProduit.Content = p.IdProduit.ToString();
                Prix.Text = p.Prix.ToString();
                CoutProduction.Text = p.CoutProduction.ToString();
                Quantite.Text = p.Quantite.ToString();
                LieuxProduction.Text = p.LieuxProduction;
            }
            else
            {
                idProduit.Content = "0";
            }
        }

        private void Click_Valider(object sender, RoutedEventArgs e)
        {
            //int idProduit = Int32.Parse((string)idProduit.Content);
            //string nom = Nom.Text;
            //double prix = double.Parse(Prix.Text);
            //double coutProduction = double.Parse(CoutProduction.Text);
            //int quantite = Int32.Parse(Quantite.Text);
            //string lieuxProduction = LieuxProduction.Text;

            Produit p = new Produit(Int32.Parse((string)idProduit.Content), Nom.Text, double.Parse(Prix.Text), double.Parse(CoutProduction.Text), Int32.Parse(Quantite.Text), LieuxProduction.Text);
            switch (Mode)
            {
                case "Ajouter": ProduitsService.AddProduit(p); break;
                case "Modifier": ProduitsService.UpdateProduit(p); break;
                case "Supprimer": ProduitsService.DeleteProduit(p); break;
            }
            this.Close();
        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Prix_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Prix.Text.StartsWith("€"))
            {
                Prix.Text = "€" + Prix.Text;
                Prix.SelectionStart = Prix.Text.Length; // place le curseur à la fin du texte
            }
        }

        private void CoutProduction_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!CoutProduction.Text.StartsWith("€"))
            {
                CoutProduction.Text = "€" + CoutProduction.Text;
                CoutProduction.SelectionStart = CoutProduction.Text.Length; // place le curseur à la fin du texte
            }
        }


    }

}
