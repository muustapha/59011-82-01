namespace API1.Models.data.Services
{
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

        }


    }

