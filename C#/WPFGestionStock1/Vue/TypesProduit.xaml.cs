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
using WPFGestionStock1.Controllers;
using WPFGestionStock1.Models;
using WPFGestionStock1.Models.Dtos;

namespace WPFGestionStock1.Vue
{
    /// <summary>
    /// Logique d'interaction pour TypesProduit.xaml
    /// </summary>
    public partial class TypesProduit : Window
    {
        private GestionstocksContext _context;
        private TypesProduitController _controller;

        public TypesProduit()
        {
            InitializeComponent();
            _context = new GestionstocksContext();
            _controller = new TypesProduitController(_context);
            Dtg.ItemsSource = _controller.GetAllTypesProduit();
        }

        private void RemplirGrid()
        {
            Dtg.ItemsSource = _controller.GetAllTypesProduit();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TypesProduit item;
            if (((Button)sender).Name == "btnAjouter")
            {
                item = new TypesProduit();
            }
            else
            {
                TypesProduitDTOOut selectedItem = Dtg.SelectedItem as TypesProduitDTOOut;
                item = new TypesProduit();
            }

            //Window w = new TypesProduitDetail(item, this, (string)((Button)sender).Content);
            // w.ShowDialog();
            RemplirGrid();
        }

        private void Row_DoubleClick(object sender, EventArgs e)
        {
            TypesProduit item = (TypesProduit)((DataGridRow)sender).Item;

            //Window w = new TypesProduitDetail(item, this, "Modifier");
            //w.ShowDialog();
            RemplirGrid();
        }
    }
}
