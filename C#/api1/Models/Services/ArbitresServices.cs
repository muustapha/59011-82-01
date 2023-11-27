using API1.Models.Data;

namespace API1.Models.data.Services;

public class ArbitresServices
{

   
        private readonly MyFootballDbContext _context;
        public ArbitresServices(MyFootballDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Arbitre> GetAllJoueurs()
        {
            return _context.Arbitres.ToList();
        }
        public Arbitre GetJoueurById(int id)
        {
            return _context.Arbitres.FirstOrDefault(a => a.IdArbitre == id);
        }
        public void AddArbitres(Arbitre a)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));

            _context.Arbitres.Add(a);
            _context.SaveChanges();
        }
        public void DeleteAbitre(Arbitre a)
        {
            //si l'objet personne est null, on renvoi une exception
            if (a == null) throw new ArgumentNullException(nameof(a));

            // on met à jour le context
            _context.Arbitres.Remove(a);
            _context.SaveChanges();
        }
        public void UpdateArbitre(Arbitre a)
        {
            _context.SaveChanges();
        }

    internal IEnumerable<Arbitre> GetAllArbitres()
    {
        throw new NotImplementedException();
    }

    internal void DeleteArbitre(Arbitre footballModelFromRepo)
    {
        throw new NotImplementedException();
    }

    internal void AddArbitres(Joueur footballPOCO)
    {
        throw new NotImplementedException();
    }
}




