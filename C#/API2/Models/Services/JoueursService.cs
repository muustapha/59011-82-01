using API2.Models;
using API2.Models.data;

namespace API2.Models.Services
{
    public class JoueursService
    {

        private readonly footballDbContext _context;
        public JoueursService(footballDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Joueur> GetAllJoueurs()
        {
            return _context.Joueurs.ToList();
        }
        public Joueur GetJoueurById(int id)
        {
            return _context.Joueurs.FirstOrDefault(j => j.IdJoueur == id);
        }
        public void AddJoueurs(Joueur j)
        {
            if (j == null) throw new ArgumentNullException(nameof(j));

            _context.Joueurs.Add(j);
            _context.SaveChanges();
        }
        public void DeleteJoueur(Joueur j)
        {
            //si l'objet personne est null, on renvoi une exception
            if (j == null) throw new ArgumentNullException(nameof(j));

            // on met à jour le context
            _context.Joueurs.Remove(j);
            _context.SaveChanges();
        }
        public void UpdateJoueur(Joueur j)
        {
            _context.SaveChanges();
        }


    }
}






