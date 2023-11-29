using API2.Models;
using API2.Models.data;

namespace API2.Models.Services
{
    public class RelationsService
    {

        private readonly footballDbContext _context;
        public RelationsService(footballDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Relation> GetAllRelations()
        {
            return _context.Relations.ToList();
        }
        public Relation GetRelationById(int id)
        {
            return _context.Relations.FirstOrDefault(r => r.IdRelation == id);
        }
        public void AddRelations(Relation r)
        {
            if (r == null) throw new ArgumentNullException(nameof(r));

            _context.Relations.Add(r);
            _context.SaveChanges();
        }
        public void DeleteRelation(Relation r)
        {
            //si l'objet personne est null, on renvoi une exception
            if (r == null) throw new ArgumentNullException(nameof(r));

            // on met à jour le context
            _context.Relations.Remove(r);
            _context.SaveChanges();
        }
        public void UpdateRelation(Relation r)
        {
            _context.SaveChanges();
        }


    }
}


