<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDbPersonne.Models.Data;

namespace WpfDbPersonne.Models.Services
{
    internal class PersonneService
    {
=======
﻿using System.Collections.Generic;
using System;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models;
using System.Linq;
using WpfDbPersonne;

public class PersonneService
{
    private readonly PersonneDbContext _contextWrite;
    private readonly PersonneDbContext _contextRead;
    //MainWindow w = new MainWindow();
    public PersonneService(PersonneDbContext contextWrite, PersonneDbContext contextRead)
    {

        _contextWrite = contextWrite;
        _contextRead = contextRead;
<<<<<<< HEAD
    }

=======
=======
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c
>>>>>>> aa304caf87c688038fbdc532dd6b71646075f7ab
        private readonly PersonneDbContext _context;

        public PersonneService(PersonneDbContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
       // public IEnumerable<Personne> GetAllPersonne()
       // {
       //     var tt = _context.Personne.ToList();
       //     return tt;
       //     //return _context.Personne.ToList();
       // }
       // public Personne GetPersonneById(int id)
       // {
       //     return _context.Personne.FirstOrDefault(p => p.IdPersonne == id);
       // }
       // public void AddPersonne(Personne p)
       // {
       //     if (p == null) throw new ArgumentNullException(nameof(p));
=======
        public IEnumerable<Personne> GetAllPersonne()
        {
<<<<<<< HEAD
             var tt =_context.Personne.ToList();
            return tt;  
=======
            var tt = _context.Personne.ToList();
            return tt;
            //return _context.Personne.ToList();
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c
        }
        public Personne GetPersonneById(int id)
        {
            return _context.Personne.FirstOrDefault(p => p.IdPersonne == id);
        }
        public void AddPersonne(Personne p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
>>>>>>> aa304caf87c688038fbdc532dd6b71646075f7ab

       //     _context.Personne.Add(p);
       //     _context.SaveChanges();
       // }
       //public void DeletePersonne(Personne p)
       // {
       //     //si l'objet personne est null, on renvoi une exception
       //     if (p == null) throw new ArgumentNullException(nameof(p));

       //     // on met à jour le context
       //     _context.Personne.Remove(p);
       //     _context.SaveChanges();
       // }
       //public void UpdatePersonne(Personne p)
       // {
       //     _context.SaveChanges();
       // }
        //nothing
        //on va mettre à jour le context dans le controller par mapping et passer
        //les modifs à la base



<<<<<<< HEAD
    //}
=======
<<<<<<< HEAD
    }
}
=======
>>>>>>> 9607937be504466c5f0905c45b8450172be80b8f
    }
>>>>>>> aa304caf87c688038fbdc532dd6b71646075f7ab

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
        //w.dtg.ItemsSource = w._controller.GetAllPersonnes();

    }
}
>>>>>>> 792324299911de2ccb8adc04230e69bc2a84aa9c
