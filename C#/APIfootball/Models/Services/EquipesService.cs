using APIfootball.Models;
using Microsoft.EntityFrameworkCore;

namespace APIfootball
{
    public class EquipesService
    {
        private readonly footballDbContext _context;

        public EquipesService(footballDbContext context)
        {
            _context = context;
        }

        public void AddEquipe(Equipe obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Equipes.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEquipe(Equipe obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Equipes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Equipe> GetAllEquipes()
        {
            return _context.Equipes.Include("Relation.Joueur").Include("Partita").ToList();
        }

        public Equipe GetEquipeById(int id)
        {
            return _context.Equipes.Include("Relation.Joueur").Include("Partita").FirstOrDefault(obj => obj.IdEquipe == id);
        }

        public void UpdateEquipe(Equipe obj)
        {
            _context.SaveChanges();
        }


    }
}

