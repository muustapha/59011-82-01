namespace APIfootball.Models.Services
{
    public class ArbitresPartitaService
    {
    

        private readonly footballDbContext _context;

        public ArbitrePartitaService(footballDBContext context)
        {
            _context = context;
        }

        public void AddArbitrePartita(ArbitrePartita obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.ArbitrePartita.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArbitrePartita(ArbitrePartita obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.ArbitrePartita.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<ArbitrePartita> GetAllArbitrePartita()
        {
            return _context.ArbitrePartita.Include("Arbitre").Include("Partita").ToList();
        }

        public ArbitrePartita GetArbitrePartitaById(int id)
        {
            return _context.ArbitrePartita.Include("Partita").Include("Arbitre").FirstOrDefault(obj => obj.IdArbitresPartita == id);
        }

        public void UpdateArbitrePartita(ArbitrePartita obj)
        {
            _context.SaveChanges();
        }


    }
}
