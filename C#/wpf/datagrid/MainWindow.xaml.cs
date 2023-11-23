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

namespace datagrid
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

        private List<Produits> CreerList()
        {
        List<Produits> liste = new List<Produits>();   
            for int i = 0; i < 9; i++)
            {Produits p = (new Produits(i, "Produit" + i, i * 3);
                Liste.add(p)
            }
            return Liste;
        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            dtgProduits.ItemsSource = CreerListe();
        }
    }
}
