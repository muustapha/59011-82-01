using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.DependencyInjection;

namespace objetModel.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

    }




}
