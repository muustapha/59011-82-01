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
    /// <summary>
    /// Logique d'interaction pour Detail.xaml
    /// </summary>
    public partial class Detail : Window
    {

        public Detail()
        { }
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
            if (Mode != "Ajouter")
            {
                IdProduit.content = p.IdProduit.ToString();
                Nom.text = p.Nom.ToString();
                Prix.text = p.Prix.ToString();
                CoutProduction.text = p.CoutProduction.ToString();
                Quantite.text = p.Quantite.ToString();
                LieuxProduction.text = p.LieuxProduction.ToString();
            }
            else
            {
                idProduit.Content = "0";
            }
        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {
            Produit p = new Produit(int Idproduit, string nom, double prix, double coutProduction, int quantite, string lieuxProduction);
                ;
            switch (Mode)
            {
                case "Ajouter": ProduitsService.AddProduit(p); break;
                case "Modifier": ProduitsService.UpdateProduit(p); break;
                case "Supprimer": ProduitsService.DeleteProduit(p); break;
            }
            this.Close();
        }
        private void annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

