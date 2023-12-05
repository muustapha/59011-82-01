using GestionCrudMvvm.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCrudMvvm.Models
{
    class ProduitsService
    {
        private readonly ProduitsDbContext _context;

        public ProduitsService(ProduitsDbContext context)
        {
            _context = context;
        }

        public void AddProduits(Produit p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.produits.Add(p);
            _context.SaveChanges();
        }

        public void DeleteProduit(Produit p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null) throw new ArgumentNullException(nameof(p));

            // on met à jour le context
            _context.produits.Remove(p);
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return _context.produits.ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _context.produits.FirstOrDefault(p => p.IdProduit == id);
        }

        public void UpdateProduit(Produit p)
        {
        }
        //nothing
        //on va mettre à jour le context dans le controller par mapping et passer
        //les modifs à la base

    }
}

