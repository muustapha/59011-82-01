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
using WPFGestionStock1.Models;
using WPFGestionStock1.Models.Data;
using WPFGestionStock1.Models.Services;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace WPFGestionStock1.Vue
{
    /// <summary>
    /// Logique d'interaction pour ArticleDetail.xaml
    /// </summary>
    public partial class ArticleDetail : Window
    {
        GestionstocksContext _context;
        ArticleService _service;
        public string Mode { get; set; }

        public ArticleDetail()
        {
            InitializeComponent();
            _context = new GestionstocksContext();
            _service = new ArticleService(_context);
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
                LibelleArticle.Text = a.LibelleArticle.ToString(); 
                QuantiteStockee.Text = a.QuantiteStockee.ToString();
                LibelleCategorie.Text = c.LibelleCategorie.ToString();

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
            a.IdArticle = int.Parse(IdArticle.Content.ToString());
            a.LibelleArticle = LibelleArticle.Text;
            a.QuantiteStockee = int.Parse(QuantiteStockee.Text);
            c.LibelleCategorie = LibelleCategorie.Text;
          
            Article a = new Article(IdArticle, LibelleArticle, QuantiteStockee, LibelleCategorie);
            switch (Mode)
            {
                case "ajouter": _service.AddArticle(a); break;
                case "modifier": _service.UpdateArticle(a); break;
                case "supprimer": _service.DeleteArticle(a); break;
            }
            this.Close();

        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
