using API2.Models;
using API2.Models.data;

namespace API2.Models.Services
{
    public class EquipesService
    {

        private readonly footballDbContext _context;
        public EquipesService(footballDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Equipe> GetAllEquipes()
        {
            return _context.Equipes.ToList();
        }
        public Equipe GetEquipeById(int id)
        {
            return _context.Equipes.FirstOrDefault(e => e.IdEquipe == id);
        }
        public void AddEquipes(Equipe e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            _context.Equipes.Add(e);
            _context.SaveChanges();
        }
        public void DeleteEquipe(Equipe e)
        {
            //si l'objet personne est null, on renvoi une exception
            if (e == null) throw new ArgumentNullException(nameof(e));

            // on met à jour le context
            _context.Equipes.Remove(e);
            _context.SaveChanges();
        }
        public void UpdateEquipe(Equipe e)
        {
            _context.SaveChanges();
        }


    }
}


