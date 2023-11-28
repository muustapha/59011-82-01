using API1.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace API1.Models.data.Services;

public class ArbitresServices
{

   
        private readonly MyFootballDbContext _context;
        public ArbitresServices(MyFootballDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Arbitre> GetAllArbitres()
        {
            return _context.Arbitres.ToList();
        }
    //public Arbitre GetArbitreById(int id)
    //{
    //    return _context.Arbitres.FirstOrDefault(a => a.IdArbitre == id);
    //}
    //public void AddArbitres(Arbitre a)
    //{
    //    if (a == null) throw new ArgumentNullException(nameof(a));

    //    _context.Arbitres.Add(a);
    //    _context.SaveChanges();
        //}
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

    internal IEnumerable<Arbitre> GetAllArbitre()
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
    public ActionResult<Arbitre> GetArbitreById(int id)
    {
        var arbitre = _context.Arbitres.FirstOrDefault(a => a.IdArbitre == id);

        if (arbitre == null)
        {
            return new NotFoundResult();
        }

        return arbitre;
    }

    internal void AddArbitres(object arbitresPOCO)
    {
        throw new NotImplementedException();
    }

    internal void UpdateArbitre(ActionResult<Arbitre> footballFromRepo)
    {
        throw new NotImplementedException();
    }

    internal void DeleteArbitre(ActionResult<Arbitre> arbitreModelFromRepo)
    {
        throw new NotImplementedException();
    }
}




