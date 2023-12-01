using APIfootball.Models;
using Microsoft.EntityFrameworkCore;

namespace APIfootball
{
    public class RelationsService
    {
  
            private readonly footballDbContext _context;

            public RelationsService(footballDbContext context)
            {
                _context = context;
            }

            public void AddRelation(Relation obj)
            {
                if (obj == null)
                {
                    throw new ArgumentNullException(nameof(obj));
                }
                _context.Relations.Add(obj);
                _context.SaveChanges();
            }

            public void DeleteRelation(Relation obj)
            {
                if (obj == null)
                {
                    throw new ArgumentNullException(nameof(obj));
                }
                _context.Relations.Remove(obj);
                _context.SaveChanges();
            }

            public IEnumerable<Relation> GetAllRelations()
            {
                return _context.Relations.Include("Joueur").Include("Equipe").ToList();
            }

            public Relation GetRelationById(int id)
            {
                return _context.Relations.Include("Equipe").Include("Joueur").FirstOrDefault(obj => obj.IdRelation == id);
            }

            public void UpdateRelation(Relation obj)
            {
                _context.SaveChanges();
            }


        }
    }
