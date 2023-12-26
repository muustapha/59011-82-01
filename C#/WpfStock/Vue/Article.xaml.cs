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
using WpfStock.Models.Data;
using WpfStock.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WpfStock.Controllers;
using WpfStock.Models.Dtos;

namespace WpfStock.Vue
{
    public partial class Article : Window
    {
        private GestionstocksContext _context;
        private ArticleController _controller;

        public Article()
        {
            InitializeComponent();

            _context = new GestionstocksContext();
            _controller = new ArticleController(_context);
            Dtg.ItemsSource = _controller.GetAllArticle();
        }

        private void RemplirGrid()
        {
            Dtg.ItemsSource = _controller.GetAllArticle();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Article item;
            if (((Button)sender).Name == "btnAjouter")
            {
                item = new Article();
            }
            else
            {
                ArticleDTOOut selectedItem = Dtg.SelectedItem as ArticleDTOOut;
                item = new Article();
            }

            //Window w = new ArticleDetail(item, this, (string)((Button)sender).Content);
           // w.ShowDialog();
            RemplirGrid();
        }

        private void Row_DoubleClick(object sender, EventArgs e)
        {
            Article item = (Article)((DataGridRow)sender).Item;

            //Window w = new ArticleDetail(item, this, "Modifier");
            //w.ShowDialog();
            RemplirGrid();
        }
    }
}