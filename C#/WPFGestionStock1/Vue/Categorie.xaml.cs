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
    /// Logique d'interaction pour Categorie.xaml
    /// </summary>
    public partial class Categorie : Window
    {
        private GestionstocksContext _context;
        private CategorieController _controller;

        public Categorie()
        {
            InitializeComponent();
            _context = new GestionstocksContext();
            _controller = new CategorieController(_context);
            Dtg.ItemsSource = _controller.GetAllCategorie();
        }

        private void RemplirGrid()
        {
            Dtg.ItemsSource = _controller.GetAllCategorie();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Categorie item;
            if (((Button)sender).Name == "btnAjouter")
            {
                item = new Categorie();
            }
            else
            {
                CategorieDTOOut selectedItem = Dtg.SelectedItem as CategorieDTOOut;
                item = new Categorie();
            }

            //Window w = new CategorieDetail(item, this, (string)((Button)sender).Content);
            // w.ShowDialog();
            RemplirGrid();
        }

        private void Row_DoubleClick(object sender, EventArgs e)
        {
            Categorie item = (Categorie)((DataGridRow)sender).Item;

            //Window w = new CategorieDetail(item, this, "Modifier");
            //w.ShowDialog();
            RemplirGrid();
        }
    }
}

