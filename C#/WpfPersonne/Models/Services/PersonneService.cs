using System.Collections.Generic;
using System;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models;
using System.Linq;

public class PersonneService
{
    private readonly PersonneDbContext _contextWrite;
    private readonly PersonneDbContext _contextRead;

    public PersonneService(PersonneDbContext contextWrite, PersonneDbContext contextRead)
    {
<<<<<<< HEAD
        _contextWrite = contextWrite;
        _contextRead = contextRead;
=======
        private readonly PersonneDbContext _context;

        public PersonneService(PersonneDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Personne> GetAllPersonne()
        {
            var tt = _context.Personne.ToList();
            return tt;
            //return _context.Personne.ToList();
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



>>>>>>> 9607937be504466c5f0905c45b8450172be80b8f
    }

    public IEnumerable<Personne> GetAllPersonne()
    {
        return _contextRead.Personne.ToList();
    }
    public Personne GetPersonneById(int id)
    {
        return _contextRead.Personne.FirstOrDefault(p => p.IdPersonne == id);
    }
    public void AddPersonne(Personne p)
    {
        if (p == null) throw new ArgumentNullException(nameof(p));

        _contextWrite.Personne.Add(p);
        _contextWrite.SaveChanges();
    }
    public void DeletePersonne(Personne p)
    {
        if (p == null) throw new ArgumentNullException(nameof(p));

        _contextWrite.Personne.Remove(p);
        _contextWrite.SaveChanges();
    }
    public void UpdatePersonne(Personne p)
    {
        _contextWrite.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _contextWrite.SaveChanges();
        _contextRead.Entry(p).Reload();
    }
}