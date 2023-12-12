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
        _contextWrite = contextWrite;
        _contextRead = contextRead;
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