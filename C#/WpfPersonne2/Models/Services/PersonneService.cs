using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDbPersonne.Models.Data;

namespace WpfDbPersonne.Models.Services
{
    internal class PersonneService
    {
        private readonly PersonneDbContext _context;

        public PersonneService(PersonneDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Personne> GetAllPersonne()
        {
             var tt =_context.Personne.ToList();
            return tt;  
        }
        public Personne GetPersonneById(int id)
        {
            return _context.Personne.FirstOrDefault(p => p.IdPersonne == id);
        }
        public void AddPersonne(Personne p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.Personne.Add(p);
            _context.SaveChanges();
        }
       public void DeletePersonne(Personne p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null) throw new ArgumentNullException(nameof(p));

            // on met à jour le context
            _context.Personne.Remove(p);
            _context.SaveChanges();
        }
       public void UpdatePersonne(Personne p)
        {
            _context.SaveChanges();
        }
        //nothing
        //on va mettre à jour le context dans le controller par mapping et passer
        //les modifs à la base



    }
}
