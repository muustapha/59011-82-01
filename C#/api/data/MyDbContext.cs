using PersonnesApi.data.Models;
using Microsoft.EntityFrameworkCore;        

namespace PersonnesApi.data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext()
        {
            
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Personne> Personnes { get; set; }
    }
}
