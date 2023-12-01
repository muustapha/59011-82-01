using Microsoft.EntityFrameworkCore;
using APIfootball.Models;


namespace APIfootball
{
    public class PartitaService
    {
        private readonly footballDbContext _context;

        public PartitaService(footballDbContext context)
        {
            _context = context;
        }

        public void AddPartita(Partita obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Partita.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePartita(Partita obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Partita.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Partita> GetAllPartita()
        {

            return _context.Partita.Include("Arbitres").Include("Equipes").ToList();
        }

        public Partita GetPartitaById(int id)
        {
            return _context.Partita.Include("Arbitres").Include("Equipes").FirstOrDefault(obj => obj.IdPartita == id);
        }
       

        public void UpdatePartita(Partita obj)
        {
            _context.SaveChanges();
        }


    }
}
