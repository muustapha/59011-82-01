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
using WPFGestionStock1.Models.Services;
using WPFGestionStock1.Models;

namespace WPFGestionStock1.Vue
{
    /// <summary>
    /// Logique d'interaction pour CategorieDetail.xaml
    /// </summary>
    public partial class CategorieDetail : Window
    {
        private GestionstocksContext _context;
        private CategorieService _service;
        string Mode;
        Categorie c;

        public CategorieDetail()
        {
            InitializeComponent();
        }

        private void Click_Valider(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {

        }
    }
}
