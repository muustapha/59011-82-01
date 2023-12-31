using System;
using System.Linq;
using System.Windows;
using WPFGestionStock1.Models;
using WPFGestionStock1.Models.Data;
using WPFGestionStock1.Models.Services;

namespace WPFGestionStock1.Vue
{
    public partial class ArticleDetail : Window
    {
        GestionstocksContext _context;
        ArticleService _service;
        string Mode;
        Article a;

        public ArticleDetail(Article item, string mode, Article article)
        {
            InitializeComponent();
            _context = new GestionstocksContext();
            _service = new ArticleService(_context);
            Mode = mode;
            a = article;
            valider.Content = Mode;
            RemplissageChamp(a);
        }

        public void RemplissageChamp(Article p)
        {
            if (p == null)
            {
                return;
            }

            if (Mode != "Ajouter")
            {
                idArticle.Content = p.IdArticle.ToString();
                LibelleArticle.Text = p.LibelleArticle;
                QuantiteStockee.Text = p.QuantiteStockee != null ? p.QuantiteStockee.ToString() : "";
                LibelleCategorie.Text = _context.Categories.FirstOrDefault(c => c.IdCategorie == p.IdCategorie)?.LibelleCategorie ?? "";
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
            uint idArticle = UInt32.Parse(IdArticle.Content.ToString());
            string libelleArticle = LibelleArticle.Text;
            int quantiteStockee = int.Parse(QuantiteStockee.Text);
            string libelleCategorie = LibelleCategorie.Text;

            // Obtenez l'idCategorie correspondant au libelleCategorie
            int idCategorie = _context.Categories.FirstOrDefault(c => c.LibelleCategorie == libelleCategorie)?.IdCategorie ?? 0;

            Article p = new Article(idArticle,libelleArticle, quantiteStockee, idCategorie);
            switch (Mode)
            {
                case "ajouter": _service.AddArticle(p); break;
                case "modifier": _service.UpdateArticle(p); break;
                case "supprimer": _service.DeleteArticle(p); break;
            }
            this.Close();
        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}