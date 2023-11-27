using API.DATA.Models;
using Microsoft.EntityFrameworkCore;


namespace API.DATA
{

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Personne> Personnes { get; set; }


    }
}
