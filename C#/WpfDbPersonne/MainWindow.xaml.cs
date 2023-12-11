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
using WpfDbPersonne.Models;
using WpfDbPersonne.Models.Controllers;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models.Services;

namespace WpfDbPersonne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonneDbContext _context;
        private PersonneController _controller;
        public MainWindow()
        {
            // scaffold-DbContext -Connection name=default -Provider MySql.EntityFrameworkCore -OutputDir Models/Data -Context PersonneDbContext -ContextDir Models

            InitializeComponent();
            _context = new PersonneDbContext();
            _controller = new PersonneController(_context);
            Dtg.ItemsSource = _controller.GetAllPersonne();

        }
        private void RemplirGrid()
        {
            //Dtg.ItemsSource = PersonneService.GetAllPersonne();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Personne item;
                if (((Button)sender).Name == "btnAjouter")
                {
                    item = new Personne();
                }
                else
                {
                    item = (Personne)Dtg.SelectedItem;
                }

                Window w = new Detail(item, this, (string)((Button)sender).Content);
                w.ShowDialog();
                RemplirGrid();
            }
            private void Row_DoubleClick(object sender, EventArgs e)
            {
                Personne item = (Personne)((DataGridRow)sender).Item;

                Window w = new Detail(item, this, "Modifier");
                w.ShowDialog();
                RemplirGrid();
            }
        }
    }
