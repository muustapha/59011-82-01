using System;
using System.Windows;
using System.Windows.Controls;
using WpfDbPersonne.Models;
using WpfDbPersonne.Models.Controllers;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models.Dtos;

namespace WpfDbPersonne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonneService _service;
        public PersonneDbContext _contextRead;
        public PersonneDbContext _contextWrite;
        private PersonneController _controller;
        public MainWindow()
        {
            InitializeComponent();

            _contextRead = new PersonneDbContext();
            _contextWrite = new PersonneDbContext();
            _controller = new PersonneController(_contextRead);
            _service = new PersonneService(_contextWrite, _contextRead);
            Dtg.ItemsSource = _controller.GetAllPersonne();
        }
        private void RemplirGrid()
        {
            Dtg.ItemsSource = _controller.GetAllPersonne();
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