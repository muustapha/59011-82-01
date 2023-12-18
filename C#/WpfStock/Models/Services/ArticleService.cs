using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStock.Models;

namespace WpfStock.Models.Services
{
    class ArticleService
    {
        private readonly GestionstocksContext _context;

        public ArticleService(GestionstocksContext context)
        {
            _context = context;
        }

        public IEnumerable<Categorie> GetAllArticle()
        {
            var tt = _context.Articles.Include(a => a.IdCategorieNavigation).ToList();
            return tt;
            //return _context.Categorie.ToList();
        }
        public Categorie GetArticleById(int id)
        {
            return _context.Articles.Include(a => a.IdCategorieNavigation).FirstOrDefault(p => p.IdArticle == id);
        }
        public void AddArticle(Categorie p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.Articles.Add(p);
            _context.SaveChanges();
        }
        public void DeleteArticle(Categorie p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null) throw new ArgumentNullException(nameof(p));

            // on met à jour le context
            _context.Articles.Remove(p);
            _context.SaveChanges();
        }
        public void UpdateArticle(Categorie p)
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