using System;
using System.Windows;
using WpfStock.Models.Data;
using WpfStock.Models;
using System.Windows.Controls;
using WpfStock.Models.Services;
using WpfStock.Vue;

namespace WpfStock
{
    public partial class Detail : Window
    {
        GestionstocksContext _contextRead;
        GestionstocksContext _contextWrite;
        ArticleService _service;

        public string Mode { get; set; }

        public Detail(Article a, MainWindow w, string mode)
        {
            InitializeComponent();
            _contextRead = new GestionstocksContext();
            _contextWrite = new GestionstocksContext();
            _service = new ArticleService(_contextWrite, _contextRead);
            Mode = mode;
            valider.Content = Mode;
            RemplissageChamp(a);
        }


        public void RemplissageChamp(Article a)
        {
            if (a == null)
            {
                return;
            }

            if (Mode != "Ajouter")
            {
                idArticle.Content = a.IdArticle.ToString();
                LibelleArticle.Text = a.LibelleArticle;
                QuantiteStockee.Text = a.QuantiteStockee != null ? a.QuantiteStockee.ToString() : "";
                LibelleCategorie.Text = a.LibelleCategorie.HasValue ? a.LibelleCategorie.Value.ToString() : "";
                           }
            else
            {
                if (idArticle != null)
                {
                    idArticle.Content = "0";
                }
            }
        }
        private void Click_Valider(object sender, RoutedEventArgs e)
        {
            uint id = UInt32.Parse(idArticle.Content.ToString());
            string libelleArticle = LibelleArticle.Text;
            int quantiteStockee = Int32.Parse(QuantiteStockee.Text);
            string libelleCategorie = LibelleCategorie.Text;

            Article a = new Article(id, libelleArticle, quantiteStockee, libelleCategorie);
            switch (Mode)
            {
                case "ajouter": _service.AddArticle(a); break;
                case "modifier": _service.UpdateArticle(a); break;
                case "supprimer": _service.DeleteArticle(a); break;
            }
            this.Close();
        }