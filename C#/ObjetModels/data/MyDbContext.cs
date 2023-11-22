using Microsoft.EntityFrameworkCore;

namespace ObjetModels.data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        
    }       
	
}
