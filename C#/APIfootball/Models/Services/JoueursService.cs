using APIfootball.Models;
using Microsoft.EntityFrameworkCore;

namespace APIfootball
{
    public class JoueursService
    {

        private readonly footballDbContext _context;

        public JoueursService(footballDbContext context)
        {
            _context = context;
        }

        public void AddJoueur(Joueur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Joueurs.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteJoueur(Joueur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Joueurs.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Joueur> GetAllJoueurs()
        {
            return _context.Joueurs.Include("Relation").ToList();
        }

        public Joueur GetJoueurById(int id)
        {
            return _context.Joueurs.Include("Relation").FirstOrDefault(obj => obj.IdJoueur == id);
        }

        public void UpdateJoueur(Joueur obj)
        {
            _context.SaveChanges();
        }


    }
}

