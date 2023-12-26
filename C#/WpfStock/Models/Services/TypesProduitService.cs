using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStock.Models.Services
{
    class TypesProduitService
    {
        private readonly GestionstocksContext _context;

        public TypesProduitService(GestionstocksContext context)
        {
            _context = context;
        }

        public IEnumerable<TypesProduit> GetAllTypesProduit()
        {
            var tt = _context.TypesProduits.ToList();
            return tt;
            //return _context.TypesProduit.ToList();
        }
        public TypesProduit GetTypesProduitById(int id)
        {
            return _context.TypesProduits.FirstOrDefault(p => p.IdTypesProduit == id);
        }
        public void AddTypesProduit(TypesProduit p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.TypesProduits.Add(p);
            _context.SaveChanges();
        }
        public void DeleteTypesProduit(TypesProduit p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null) throw new ArgumentNullException(nameof(p));

            // on met à jour le context
            _context.TypesProduits.Remove(p);
            _context.SaveChanges();
        }
        public void UpdateTypesProduit(TypesProduit p)
        {

            _context.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            _context.Entry(p).Reload();
        }
        //nothing
        //on va mettre à jour le context dans le controller par mapping et passer
        //les modifs à la base



    }
}