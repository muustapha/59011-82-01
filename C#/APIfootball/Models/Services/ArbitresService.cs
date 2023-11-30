using APIfootball.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace APIfootball
{
    public class ArbitresService
    {
        private readonly footballDbContext _context;

        public ArbitresService(footballDbContext context)
        {
            _context = context;
        }

        public void AddArbitre(Arbitre obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Arbitres.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArbitre(Arbitre obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Arbitres.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Arbitre> GetAllArbitre()
        {
            return _context.Arbitres.Include("Partita").ToList();
        }

        public Arbitre GetArbitreById(int id)
        {
            return _context.Arbitres.Include("Partita").FirstOrDefault(obj => obj.IdArbitre == id);
        }

        public void UpdateArbitre(Arbitre obj)
        {
            _context.SaveChanges();
        }


    }
}
