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
using WpfStock.Models.Services;

namespace WpfStock.Vue
{
    /// <summary>
    /// Logique d'interaction pour ArticleDetail.xaml
    /// </summary>
    public partial class ArticleDetail : Window
    {
        GestionstocksContext _context;
        ArticleService _service;

        public string Mode { get; set; }

        public ArticleDetail(Article a, MainWindow w, string mode)
        {
            InitializeComponent();
        }
    }
}
