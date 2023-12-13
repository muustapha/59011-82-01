using System;
<<<<<<< HEAD
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
=======
using System.Windows;
using System.Windows.Controls;
using WpfDbPersonne.Models;
using WpfDbPersonne.Models.Controllers;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models.Dtos;
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c

namespace WpfDbPersonne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonneDbContext _context;
<<<<<<< HEAD
        private PersonneController _controller;
        public MainWindow()
        {
            // scaffold-DbContext -Connection name=default -Provider MySql.EntityFrameworkCore -OutputDir Models/Data -Context PersonneDbContext -ContextDir Models
=======
        private PersonneController _controller; 
        //private PersonneService _service;
        public MainWindow()
        {
            InitializeComponent();
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c

            InitializeComponent();
            _context = new PersonneDbContext();
            _controller = new PersonneController(_context);
<<<<<<< HEAD
            Dtg.ItemsSource = _controller.GetAllPersonne();

=======
            //_service = new PersonneService(_context);
            Dtg.ItemsSource = _controller.GetAllPersonne();
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c
        }
        private void RemplirGrid()
        {
            Dtg.ItemsSource = _controller.GetAllPersonne();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
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
=======
            Personne item;
            if (((Button)sender).Name == "btnAjouter")
            {
                item = new Personne();
            }
            else
            {
                PersonneDTO selectedItem = Dtg.SelectedItem as PersonneDTO;
                //item = (Personne)Dtg.SelectedItem;
                item = new Personne(selectedItem!.IdPersonne, selectedItem!.Nom, selectedItem.Prenom, selectedItem.CodePostal!, selectedItem.Adresse, selectedItem.Ville);
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
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c
