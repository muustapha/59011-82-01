using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Data; 

namespace WPFGestionStock1.Models.Services
{
    class CategorieService
    {

        private readonly GestionstocksContext _context;

        public CategorieService(GestionstocksContext context)
        {
            _context = context;
        }

        public IEnumerable<Categorie> GetAllCategorie()
        {
            var tt = _context.Categories.Include(a => a.TypesProduit).ToList();
            return tt;
            //return _context.Categorie.ToList();
        }
        public Categorie GetCategorieById(int id)
        {
            return _context.Categories.Include(a => a.TypesProduit).FirstOrDefault(p => p.IdCategorie == id);
        }
        public void AddCategorie(Categorie p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.Categories.Add(p);
            _context.SaveChanges();
        }
        public void DeleteCategorie(Categorie p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null) throw new ArgumentNullException(nameof(p));

            // on met à jour le context
            _context.Categories.Remove(p);
            _context.SaveChanges();
        }
        public void UpdateCategorie(Categorie p)
        {

            _context.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            _context.Entry(p).Reload();
        }
        //nothing
        //on va mettre à jour le context dans le controller par mapping et passer
        //les modifs à la base



    }
}