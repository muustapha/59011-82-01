using API2.Models.data;
using Microsoft.AspNetCore.Mvc;

namespace API2.Models.Services
{
    public class PartitaService
    {

        private readonly footballDbContext _context;
        public PartitaService(footballDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Partita> GetAllPartitas()
        {
            return _context.Partita.ToList();
        }
        //public Partita GetPartitaById(int id)
        //{
        //    return _context.Partitas.FirstOrDefault(a => a.IdPartita == id);
        //}
        //public void AddPartitas(Partita a)
        //{
        //    if (a == null) throw new ArgumentNullException(nameof(a));

        //    _context.Partitas.Add(a);
        //    _context.SaveChanges();
        //}
        public void DeleteAbitre(Partita a)
        {
            //si l'objet personne est null, on renvoi une exception
            if (a == null) throw new ArgumentNullException(nameof(a));

            // on met à jour le context
            _context.Partita.Remove(a);
            _context.SaveChanges();
        }
        public void UpdatePartita(Partita p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.Partita.Update(p);
            _context.SaveChanges();
        }
        internal IEnumerable<Partita> GetAllPartita()
        {
            throw new NotImplementedException();
        }

        internal void DeletePartita(Partita footballModelFromRepo)
        {
            throw new NotImplementedException();
        }

        internal void AddPartitas(Joueur footballPOCO)
        {
            throw new NotImplementedException();
        }
        public ActionResult<Partita> GetPartitaById(int id)
        {
            var arbitre = _context.Partita.FirstOrDefault(a => a.IdPartita == id);

            if (arbitre == null)
            {
                return new NotFoundResult();
            }

            return arbitre;
        }

        internal void AddPartita(object arbitresPOCO)
        {
            throw new NotImplementedException();
        }

        internal void UpdatePartita(ActionResult<Partita> footballFromRepo)
        {
            throw new NotImplementedException();
        }

        internal void DeletePartita(ActionResult<Partita> arbitreModelFromRepo)
        {
            throw new NotImplementedException();
        }
    }
}
