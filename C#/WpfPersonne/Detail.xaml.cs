using System;
using System.Windows;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models;

namespace WpfDbPersonne
{
    public partial class Detail : Window
    {
        PersonneDbContext _contextRead;
        PersonneDbContext _contextWrite;
        PersonneService _service;

        public string Mode { get; set; }

        public Detail(Personne p, MainWindow w, string mode)
        {
            InitializeComponent();
            _contextRead = new PersonneDbContext();
            _contextWrite = new PersonneDbContext();
            _service = new PersonneService(_contextWrite, _contextRead);
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
                idPersonne.Content = p.IdPersonne.ToString();
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
           uint id = UInt32.Parse(idPersonne.Content.ToString());
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            int codePostal = Int32.Parse(CodePostal.Text);
            string ville = Ville.Text;
            string adresse = Adresse.Text;

            Personne p = new Personne(id, nom, prenom, codePostal, adresse, ville);
            switch (Mode)
            {
                case "ajouter": _service.AddPersonne(p); break;
                case "modifier": _service.UpdatePersonne(p); break;
                case "supprimer": _service.DeletePersonne(p); break;
            }
            this.Close();
        }
        private void Click_Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




    }

}
