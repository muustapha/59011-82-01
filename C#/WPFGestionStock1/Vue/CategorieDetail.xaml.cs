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
using WPFGestionStock1.Controllers;
using WPFGestionStock1.Models;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using WPFGestionStock1.Models.Data;
using WPFGestionStock1.Models.Services;

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
            _context = new GestionstocksContext();
            _service = new CategorieService(_context);
            Mode = mode;
            c = categorie;
            valider.Content = Mode;
            RemplissageChamp(c);
        }
        public void RemplissageChamp(Categorie c)
        {
            if (c == null)
            {
                return;
            }

            if (Mode != "Ajouter")
            {
                idCategorie.Content = c.IdCategorie.ToString();
                LibelleCategorie.Text = c.LibelleCategorie;
                LibelleTypeProduit.Text = _context.TypesProduits.FirstOrDefault(c => c.IdTypeProduit == c.IdTypeProduit)?.LibelleTypeProduit ?? "";
            }
            else
            {
                if (idCategorie != null)
                {
                    idCategorie.Content = "0";
                }
            }
        }
        private void Click_Valider(object sender, RoutedEventArgs e)
        {

            uint idCategorie = UInt32.Parse(IdCategorie.Content.ToString());
            string libelleCategorie = LibelleCategorie.Text;
            string libelleTypeProduit = LibelleTypeProduit.Text;

            // Obtenez l'idCategorie correspondant au libelleCategorie
            int idTypeProduit = _context.TypesProduits.FirstOrDefault(t => t.LibelleTypeProduit == LibelleTypeProduit)?.IdTypeProduit ?? 0;

            Categorie p = new Categorie(idCategorie, libelleCategorie, , idTypeProduit);
            switch (Mode)
            {
                case "ajouter": _service.AddCategorie(p); break;
                case "modifier": _service.UpdateCategorie(p); break;
                case "supprimer": _service.DeleteCategorie(p); break;
            }
            this.Close();
        }

        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
