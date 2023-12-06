using GestionCrudMvvm.vue;
using GestionCrudMvvm;
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
            RemplirGrid();
        }
        private void RemplirGrid()
        {
            dtgProduit.ItemsSource = ProduitsService.GetAllProduit();
        }

        private void btnActionClick(object sender, EventArgs e)
        {
            Produit item;
            if (((Button)sender).Name == "btnAjouter")
            {
                item = new Produit();
            }
            else
            {
                item = (Produit)dtgProduit.SelectedItem;
            }

            Window w = new Detail(item, this, (string)((Button)sender).Content);
            w.ShowDialog();
            RemplirGrid();
        }
        private void Row_DoubleClick(object sender, EventArgs e)
        {
            Produit item = (Produit)((DataGridRow)sender).Item;

            Window w = new Detail(item, this, "Modifier");
            w.ShowDialog();
            RemplirGrid();
        }
    }
}
