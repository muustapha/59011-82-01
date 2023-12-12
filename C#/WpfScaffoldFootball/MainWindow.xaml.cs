using Microsoft.EntityFrameworkCore;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WpfScaffoldFootball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private footballDbContext _context;
        private footballController _controller;
        public MainWindow()
        {
            InitializeComponent();
            _context = new footballDbContext();
            _controller = new footballController(_context);
            dtg.ItemsSource = _controller.GetAllfootball();

        }

       
    }
}
