using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Data;

namespace WPFGestionStock1.Models.Services
{
    class ArticleService
    {
        private readonly GestionstocksContext _context;

        public ArticleService(GestionstocksContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> GetAllArticle()
        {
            return _context.Articles.Include("Categorie").ToList();
            //return _context.Article.ToList();
        }
        public Article GetArticleById(int id)
        {
            return _context.Articles.Include("Categorie").FirstOrDefault(a => a.IdArticle == id);
        }
        public void AddArticle(Article a)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));

            _context.Articles.Add(a);
            _context.SaveChanges();
        }
        public void DeleteArticle(Article a)
        {
            //si l'objet personne est null, on renvoi une exception
            if (a == null) throw new ArgumentNullException(nameof(a));

            // on met à jour le context
            _context.Articles.Remove(a);
            _context.SaveChanges();
        }
        public void UpdateArticle(Article a)
        {

            _context.Entry(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            _context.Entry(a).Reload();
        }
        //nothing
        //on va mettre à jour le context dans le controller par mapping et passer
        //les modifs à la base



    }
}