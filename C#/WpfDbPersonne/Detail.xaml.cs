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
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WpfDbPersonne.Models;
using WpfDbPersonne.Models.Services;

namespace WpfDbPersonne
{
    public partial class Detail : Window
    {
        PersonneDbContext _context;
        PersonneService _service;

        public string Mode { get; set; }

        public Detail(Personne p, MainWindow w, string mode)
        {
            InitializeComponent();
            _context = new PersonneDbContext();
            _service = new PersonneService(_context);
            Mode = mode;
            valider.Content = Mode;
            RemplissageChamp(p);
        }

        public void RemplissageChamp(Personne p)
        {
            if (p == null)
            {
                return;
            }

            if (Mode != "Ajouter")
            {
                Nom.Text = p.Nom;
                Prenom.Text = p.Prenom != null ? p.Prenom.ToString() : "";
                CodePostal.Text = p.CodePostal.HasValue ? p.CodePostal.Value.ToString() : "";
                Adresse.Text = p.Adresse;
                Ville.Text = p.Ville;
            }
            else
            {
                if (idPersonne != null)
                {
                    idPersonne.Content = "0";
                }
            }
        }
        private void Click_Valider(object sender, RoutedEventArgs e)
        {
           
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            int codePostal = Int32.Parse(CodePostal.Text);
            string ville = Ville.Text;
            string adresse = Adresse.Text;

            Personne p = new Personne(nom, prenom, codePostal, adresse, ville);
            switch (Mode)
            {
                case "Ajouter": _service.AddPersonne(p); break;
                case "Modifier": _service.UpdatePersonne(p); break;
                case "Supprimer": _service.DeletePersonne(p); break;
            }
            this.Close();
        }
        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




    }

}
